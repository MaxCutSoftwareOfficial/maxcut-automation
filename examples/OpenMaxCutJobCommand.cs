using System.Diagnostics;

namespace examples;

/**
 * <summary>
 * The <c>OpenMaxCutJobCommand</c> class is responsible for executing the MaxCut software command line interface to import open a MaxCut job file.
 * This class uses the <c>System.Diagnostics.Process</c> class to run the MaxCut executable with the appropriate arguments.
 * </summary>
 *
 * <remarks>
 * For more information about MaxCut software, visit <a href="https://www.maxcutsoftware.com">MaxCut Software</a>.
 * </remarks>
 */
public class OpenMaxCutJobCommand
{
    /**
     * <summary>Specify the file using --file option. If you would like to optimize the job then include the --optimize option.</summary>
     *
     * <param name="filePath">The path of the MaxCut job file (.mc3) to be imported.</param>
    */
    public void Run(string filePath)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = @"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe",
            Arguments = $"open --file \"{filePath}\" --optimize",
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