using System.Reflection;
using examples;

// Example of activating a license code via the MaxCut command line interface.
// var activateCommand = new ActivateCommand();
// activateCommand.Run("my-license-code");

// Example of importing a KDMax file via the MaxCut command line interface.
var entryAssemblyDirectory = AppContext.BaseDirectory;
var importKdMaxCommand = new ImportKdMaxCommand();
importKdMaxCommand.Run($"{entryAssemblyDirectory}\\kdmax.csv");