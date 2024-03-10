# FUDLoader

FUDLoader is a lightweight tool written in C# that facilitates the generation of VBScript files. These VBScript files enable the quick and stealthy download and placement of files from a remote host.

## Features

- **Profile Management**: Organize and manage different configurations and settings conveniently through profiles.
- **Duckyscript Generation**: Automate the generation of Duckyscript, streamlining the process of creating payloads for USB Rubber Ducky or similar devices that use DuckyScript.

## Usage

1. **Clone the Repository**: Clone the FUDLoader repository to your local machine using Git:
   ```bash
   git clone https://github.com/WilleLX1/FUDLoader.git

2. **Open the project and build**: Open the project and build the project yourself:
* Open the `.sln` file in project
* Press `CTRL + B` to build project.
* Open the binary generated, in `bin\Debug\net8.0-windows`.

3. **Prepare the loader**: Add files you want to download and build the payload:
* Press `Add Item` button for every file you want to download.
* Customize the checkboxes and textboxes to your liking.
* When done with every file, you can either check the DuckyScript checkbox or skip it and just build the VBScript payload alone.
  
> [!WARNING]
> Ensure that the generated `.vbs` file is uploaded to a public web server to ensure proper functionality of the Duckyscript.

4. **Start the payload**: Open the generated `.vbs` file or execute the bad USB payload.

## Support
If you encounter any issues or have questions about FUDLoader, feel free to open an issue on GitHub.

## Disclaimer
FUDLoader is intended for educational and research purposes only. The authors do not condone or endorse any illegal activities facilitated by the use of this software.
