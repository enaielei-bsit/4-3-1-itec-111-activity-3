namespace _4_3_1_itec_111_activity_3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Session.ciphers.Add("Caesar", new Caesar(1));

            Session.caesar = new();
            Session.caesar.Hide();

            Application.Run(new SimpleCipher());
        }
    }
}