# sect
Simple Elliptic Curve Tool

This tool runs on Windows and Linux without installation. Download the latest version from the [releases page](https://github.com/jopohl/sect/releases) and follow the instructions for your OS below.

##### Windows
Install [.NET Framework 4.0](https://dotnet.microsoft.com/download/dotnet-framework/net40) & run ```Simple_Elliptic_Curve_Tool.exe```. 

##### Linux
Install Mono & run ```mono Simple_Elliptic_Curve_Tool.exe```. 

##### macOS (Unsupported)
Unfortunately, this application does __not run on macOS 10.15 Catalina and above__ due to https://github.com/mono/mono/issues/17301.

If you use a macOS version <10.15, you may be lucky by installing Mono & running ```mono --arch=32 Simple_Elliptic_Curve_Tool.exe```. 

# Screenshots

![Point addition Z_p](/screenshots/add_z_p.png?raw=true "Point addition for elliptic curve over Z_p")
![Point multiplication Z_p](/screenshots/mult_z_p_log.png?raw=true "Point multiplication for a curve over Z_p with log")
![Point addition R](/screenshots/add_r.png?raw=true "Point addition for elliptic curve over R")
