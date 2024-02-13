# installation instructions

Installation Steps:

1. Install Node 8.6.0 from <https://nodejs.org/download/release/v8.6.0/>

2. Visual C++ Build Environment:
    - Option 1: Install Visual C++ Build Tools using the Default Install option.
    - Option 2: Install Visual Studio 2015 (or modify an existing installation) and select Common Tools for Visual C++ during setup. This also works with the free Community and Express for Desktop editions.
        [Windows Vista / 7 only] requires .NET Framework 4.5.1

3. Install Python 2.7 (v3.x.x is not supported), and run npm config set python python2.7 (or see below for further instructions on specifying the proper Python version and path.)

4. Launch cmd, npm config set msvs_version 2015

5. Set strict-ssl=false for npm
    - npm set config strict-ssl=false

6. Set NODE_TLS_REJECT_UNAUTHORIZED to 0
    - need to set this on multiple parts
        - CMD
            - set NODE_TLS_REJECT_UNAUTHORIZED = 0
        - Powershell
            - $env:NODE_TLS_REJECT_UNAUTHORIZED=0
        - Bash
            - execute NODE_TLS_REJECT_UNAUTHORIZED=0
        - npm
            - npm config set NODE_TLS_REJECT_UNAUTHORIZED=0
        - User Environment Variable
            - Press WindowsKey + Pause
            - Click Advanced System Settings
            - Select Environment Variables
            - Under User Variables select New
            - Variable Name: NODE_TLS_REJECT_UNAUTHORIZED
            - Varable Value: 0

7. Steps 5 and 6 are needed only due to the Network Security on SSL and proxies
    - If you are using this outside the network than the above two settings most likely will not be needed

5. Run command, npm install
    - This should install all the packages and run electron-rebuild at the end