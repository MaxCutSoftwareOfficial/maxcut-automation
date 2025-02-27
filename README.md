# Cutlist Optimizer – MaxCut
A powerful and easy-to-use cutlist optimizer for cabinetry and woodworking professionals. Save materials, reduce costly mistakes, and generate accurate quotes.

- Optimize cutting plans with minimal waste
- Generate accurate quotations effortlessly
- Automate workflows with CLI integration

📢 Try MaxCut for free → [https://maxcutsoftware.com](https://maxcutsoftware.com)

## MaxCut CLI - Introduction

[Download](https://maxcutsoftware.com) and install MaxCut (free)

This repository provides examples of how to integrate MaxCut with your workflow using the command line.
The MaxCut CLI (Command Line Interface) comes pre-packaged with MaxCut.
We have created several C# [examples](examples/) in a .Net console application to help you get started.

## Importing data via the Command Line

### Importing KDMax data file
Run the following command in your windows command prompt `cmd.exe`
```
"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe" import --file "file path" --format kdmax
```
Example: [ImportKdMaxCommand.cs](examples/ImportKdMaxCommand.cs) is used in [Program.cs](examples/Program.cs).

### Importing CabMaster data file
Run the following command in your windows command prompt `cmd.exe`
```
"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe" import --file "file path" --format cabmaster
```
Example: [ImportCabMasterCommand.cs](examples/ImportCabMasterCommand.cs) is used in [Program.cs](examples/Program.cs).

### Running an optimization on a imported file
To run the optimization on an imported or opened file include the `--optimize` option in your arguments

### Opening a MaxCut job via the Command Line
Run the following command in your windows command prompt `cmd.exe`
```
"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe" open --file "file path"
```
Example: [OpenMaxCutJobCommand.cs](examples/OpenMaxCutJobCommand.cs) is used in [Program.cs](examples/Program.cs).

## License management via the Command Line

### Activating a license
Run the following command in your windows command prompt `cmd.exe`
```
"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe" license --activate "license code"
```
Example: [LicenseActivateCommand.cs](examples/LicenseActivateCommand.cs) is used in [Program.cs](examples/Program.cs).

### Getting license details
Run the following command in your windows command prompt `cmd.exe`
```
"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe" license --details
```
Example: [LicenseInfoCommand.cs](examples/LicenseInfoCommand.cs) is used in [Program.cs](examples/Program.cs).

### Deactivating a license
Run the following command in your windows command prompt `cmd.exe`
```
"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe" license --deactivate
```

Example: [LicenseDeactivateCommand.cs](examples/LicenseDeactivateCommand.cs) is used in [Program.cs](examples/Program.cs).

