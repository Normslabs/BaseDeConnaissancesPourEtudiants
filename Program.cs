using BaseDeConnaissancesEtudiants.Business;

namespace BaseDeConnaissancesEtudiants;

/// <summary>
/// Entry point class of the application
/// </summary>
internal static class Program {
    public static int EXIT_CODE { get;  set; } = 0;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static int Main(string[] args) {
        new MainApplication().Run();
        return EXIT_CODE;
    }
}