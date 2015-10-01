using System;
using System.Windows.Forms;

namespace GameOfLifeCSharp
{
    static class Cotroller
    {
        public static bool randomRocks = true;
        public static bool rockWall = true;
        public static int rockIsland = 3;

        /// <summary>
        /// Az alkalmazás belépési pontja
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
