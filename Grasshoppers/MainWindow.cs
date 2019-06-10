using System;
using GLib;
using Gtk;

namespace Grasshoppers
{
    internal partial class MainWindow : Window
    {

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
            InitializeComponents();
        }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow_ApplicationWindow").Handle)
        {
            builder.Autoconnect(this);
            
            
        }

        [ConnectBefore]
        private void QuitItem_OnActivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}