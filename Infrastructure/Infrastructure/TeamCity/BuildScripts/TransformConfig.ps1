param (
    [string]$src = "",
    [string]$xdt = "",
    [string]$dst = ""
)

Add-Type -Path "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\Microsoft\VisualStudio\v15.0\Web\Microsoft.Web.XmlTransform.dll"

try 
{
    Write-Host 'applyConfigTransformation - Called'
    Write-Host $src
    $doc = New-Object Microsoft.Web.XmlTransform.XmlTransformableDocument
    $doc.PreserveWhiteSpace = $true
    Write-Host 'applyConfigTransformation - Load Called'
    $doc.Load($src)
    Write-Host 'applyConfigTransformation - Load completed'

    $trn = New-Object Microsoft.Web.XmlTransform.XmlTransformation($xdt)

    if ($trn.Apply($doc))
    {
        Write-Host 'applyConfigTransformation - $trn.Apply called'
        $doc.Save($dst)
        Write-Output "Output file: $dst"
        Write-Host 'applyConfigTransformation - $trn.Apply completed'
    }
    else
    {
        throw "Transformation terminated with status False"
    }
}
catch
{
    Write-Output $_
    Exit 1
}