param (
    [String]$src = "",
    [String]$dst = "",
    [String]$dstServer = "",
    [String]$dstUsername = "",
    [String]$dstPassword = ""
)

$srcFiles = New-Object System.Collections.Generic.Dictionary"[String,String]"
$dstFiles = New-Object System.Collections.Generic.Dictionary"[String,String]"

try {

    Write-Output "Generating Hash for Source location`r`n"

    Get-ChildItem -Path $src -Recurse -Depth 25 -Attributes !Directory+!System |
    ForEach-Object {
        $srcFiles.Add(
            $_.FullName.Replace($src, ""),
            ($_ | Get-FileHash -Algorithm MD5).Hash
        )
    }

    Write-Output "Generated Hash for Source location`r`n"

    if (![string]::IsNullOrEmpty($dstServer)) {
    	$password = ConvertTo-SecureString $dstPassword -AsPlainText -Force
    	$cred = New-Object System.Management.Automation.PSCredential ($dstUsername, $password )
    
        NET USE $dstServer /USER:$dstUsername $dstPassword
    }

    Write-Output "Generating Hash for Desination location`r`n"

    if (![string]::IsNullOrEmpty($dstServer)) {
            
        $Session = New-PSSession -ComputerName $dstServer.Replace("\\", "") -Credential $cred

        $dstFiles = Invoke-Command -Session $session -ScriptBlock {
            $dstFiles = New-Object System.Collections.Generic.Dictionary"[String,String]"
    
            Get-ChildItem -Path $Using:dst -Recurse -Depth 25 -Attributes !Directory+!System |
            ForEach-Object {
                $dstFiles.Add(
                    $_.FullName.Replace($Using:dst, ""),
                    ($_ | Get-FileHash -Algorithm MD5).Hash
                )
            }
    
            $dstFiles | Export-Clixml -Path "$Using:dst\filehash.xml"

            return $dstFiles
        }
    }
    else {
        Get-ChildItem -Path $dst -Recurse -Depth 25 -Attributes !Directory+!System |
        ForEach-Object {
            $dstFiles.Add(
                $_.FullName.Replace($dst, ""),
                ($_ | Get-FileHash -Algorithm MD5).Hash
            )
        }

        $dstFiles | Export-Clixml -Path "$dst\filehash.xml"
    }

    if ((Test-Path "$dst\filehash.xml") -eq $false) {
        throw "Unable to create File Hashes for destination"
    }
    else {
        Write-Output "Generated Hash for Destination location"
    }
        

	$filesToExclude = New-Object System.Collections.Generic.List"[String]"

	foreach ($key in $srcFiles.Keys) {
		[bool]$excludeFile = $false

		if ($dstFiles.ContainsKey($key)) {
			if ($srcFiles[$key] -eq $dstFiles[$key]) {
				$excludeFile = $true
			}
		}

		if ($excludeFile) {
			$filesToExclude.Add("$src$key")
		}
	}


	$files = [string]::Join("`n`t", $filesToExclude.ToArray())

    $jobText = "
::
:: Robocopy Job $src\ROBOCOPYJOB.RCJ
::
:: 
::
::
:: Source Directory :
::
	/SD:$src	:: Source Directory.
::
:: Destination Directory :
::
	/DD:$dst	:: Destination Directory.
::
:: Include These Files :
::
	/IF		:: Include Files matching these names
::		*.*	:: Include all names (currently - Command Line may override)
::
:: Exclude These Directories :
::
	/XD		:: eXclude Directories matching these names
::			:: eXclude no names (currently - Command Line may override)
::
:: Exclude These Files :
::
    /XF		:: eXclude Files matching these names
        robocopyjob.RCJ
        $files
::
:: Copy options :
::
	/S		:: copy Subdirectories, but not empty ones.
	/DCOPY:DA	:: what to COPY for directories (default is /DCOPY:DA).
	/COPY:DAT	:: what to COPY for files (default is /COPY:DAT).
	/PURGE		:: delete dest files/dirs that no longer exist in source.
::
:: Retry Options :
::
	/R:1000000	:: number of Retries on failed copies: default 1 million.
	/W:30		:: Wait time between retries: default is 30 seconds.
::
:: Logging Options :
::
"

    Set-Content -Path "$src\robocopyjob.RCJ" -Value $jobText

    if ((Test-Path -Path "$src\robocopyjob.RCJ") -eq $true) {
        if($filesToExclude.Count -eq $srcFiles.Count)
        {
        	Write-Output "Running Robocopy Command: robocopy /MT:24 /PURGE /S /NJH /JOB:robocopyjob"
            robocopy /MT:24 /PURGE /S /NJH /JOB:robocopyjob
        }
        else
        {
        	Write-Output "Running Robocopy Command: robocopy /MT:24 /PURGE /S /JOB:robocopyjob"
            robocopy /MT:24 /PURGE /S /JOB:robocopyjob
        }

        Remove-Item "$src\robocopyjob.RCJ"

        Write-Output "Robocopy Exit Code: $lastexitcode"
            
        if ($lastexitcode -gt 3) {
            exit 1
        }
        else {
            exit 0
        }
    }

    exit 0
}
catch {
    Write-Output $_
    exit 1
}