using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Grasshoppers
{
    class MainWindow : Window
    {

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
        }

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow_ApplicationWindow").Handle)
        {
            builder.Autoconnect(this);
        }
    }
}