using System;
using Gtk;

namespace Grasshoppers
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.Grasshoppers.Grasshoppers", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow(new GrasshoppersQueryProvider());
            
            win.DeleteEvent += (sender, eventArgs) => {  Application.Quit(); };

            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}