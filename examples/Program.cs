using System.Reflection;
using examples;

var entryAssemblyDirectory = AppContext.BaseDirectory;

// Example of activating a license code via the MaxCut command line interface.
// var activateCommand = new ActivateCommand();
// activateCommand.Run("my-license-code");

// Example of importing a KDMax file via the MaxCut command line interface.
// var importKdMaxCommand = new ImportKdMaxCommand();
// importKdMaxCommand.Run($"{entryAssemblyDirectory}\\kdmax.csv");

// Example of importing a Cab Master file via the MaxCut command line interface.
var importCabMasterCommand = new ImportCabMasterCommand();
importCabMasterCommand.Run($"{entryAssemblyDirectory}\\cabmaster.csv");