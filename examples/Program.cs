using System.Reflection;
using examples;

var entryAssemblyDirectory = AppContext.BaseDirectory;

// Example of activating a license code via the MaxCut command line interface.
// var activateCommand = new ActivateCommand();
// activateCommand.Run("my-license-code");

// Example of importing a KDMax file via the MaxCut command line interface.
// var importKdMaxCommand = new ImportKdMaxCommand();
// importKdMaxCommand.Run($"{entryAssemblyDirectory}\\test_files\\kdmax.csv");

// Example of importing a Cab Master file via the MaxCut command line interface.
// var importCabMasterCommand = new ImportCabMasterCommand();
// importCabMasterCommand.Run($"{entryAssemblyDirectory}\\test_files\\cabmaster.csv");

// Example of opening a MaxCut job file (.mc3) via the MaxCut command line interface.
var openMaxCutJobCommand = new OpenMaxCutJobCommand();
openMaxCutJobCommand.Run($"{entryAssemblyDirectory}\\test_files\\F300.mc3");