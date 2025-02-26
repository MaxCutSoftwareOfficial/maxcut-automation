using System.Diagnostics;

namespace examples;

/**
 * <summary>
 * The <c>LicenseInfoCommand</c> class is responsible for executing the MaxCut software command line interface to get license information.
 * This class uses the <c>System.Diagnostics.Process</c> class to run the MaxCut executable with the appropriate arguments.
 * </summary>
 *
 * <remarks>
 * For more information about MaxCut software, visit <a href="https://www.maxcutsoftware.com">MaxCut Software</a>.
 * </remarks>
 */
public class LicenseInfoCommand
{
    /**
     * <summary>Runs the MaxCut executable to get license information.</summary>
    */
    public void Run()
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = @"C:\Program Files (x86)\MaxCut Software\MaxCut\MaxCut.exe",
            Arguments = $"license --details",
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