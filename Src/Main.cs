
namespace RobotMananager;

internal static class EntryPoint {
    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainWindow());
    }
}
