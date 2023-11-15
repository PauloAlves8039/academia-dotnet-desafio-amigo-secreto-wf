namespace Academia.DotNet.AmigoSecreto.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Inicio());
        }
    }
}