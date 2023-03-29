using System;
using System.Windows.Forms;

namespace Generating_num_sequences
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Задаем стартовое окно
            Application.Run(new Start());
        }
    }
}
