using System;
using Gtk;

namespace Kolokvium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Classes.ProgramLogic program = new Classes.ProgramLogic(); // my add
            Application.Run();
        }
    }
}
