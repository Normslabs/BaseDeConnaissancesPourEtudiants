using BaseDeConnaissancesEtudiants.Business.Interfaces;
using BaseDeConnaissancesEtudiants.Presentation;
using NSAIL;
using NSAIL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.Business;

/// <summary>
/// Main service of the application.
/// </summary>
public class MainApplication : AbstractApplication {
    
    public MainApplication() {
        ApplicationConfiguration.Initialize();
        this.Components.RegisterService(new TestKnowledgeComponentProvider(this));
        this.Components.RegisterView(new MainWindow(this));
        this.Components.GetViewByType<MainWindow>()?.FillKnowledgeComponentList(this.Components.GetServiceByType<IKnowledgeComponentProvider>());
    }

    public override void Run() {
        int exitCode = 0;
        try {
            Application.Run(this.Components.GetViewByType<MainWindow>());
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
            exitCode = ex is AbstractException ? (ex as AbstractException)?.ErrorNo ?? 1 : 1;
        }
        this.Terminate(exitCode);
    }

    public override void Terminate(int exitCode) {
        Program.EXIT_CODE = exitCode;
        Application.Exit();
    }
}
