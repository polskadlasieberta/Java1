using System;
using System.Windows.Forms;

namespace INF._04_01_23._01_SG
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 okno = new Form1();
            Application.Run(okno);
        }
    }
}
