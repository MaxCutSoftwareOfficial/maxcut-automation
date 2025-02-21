using System.Diagnostics;

namespace examples;

/**
 * <summary>
 * The <c>ImportKDMaxCommand</c> class is responsible for executing the MaxCut software command line interface to import a KDMax CSV file.
 * This class uses the <c>System.Diagnostics.Process</c> class to run the MaxCut executable with the appropriate arguments.
 * </summary>
 *
 * <remarks>
 * For more information about MaxCut software, visit <a href="https://www.maxcutsoftware.com">MaxCut Software</a>.
 * </remarks>
 */
public class ImportKdMaxCommand
{
    /**
     * <summary>Specify the file using --file and set the --format to kdmax. If you would like to optimize the job then include the --optimize option.</summary>
     *
     * <param name="filePath">The path of the KDMax CSV file to be imported.</param>
    */
    public void Run(string filePath)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = @"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe",
            Arguments = $"import --file \"{filePath}\" --format kdmax --optimize",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(startInfo);
        process?.WaitForExit();

        if (process == null) return;

        var result = process.StandardOutput.ReadToEnd();

        Console.WriteLine(result);
    }
}