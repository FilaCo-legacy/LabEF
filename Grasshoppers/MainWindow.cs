using System;
using GLib;
using Gtk;

namespace Grasshoppers
{
    internal partial class MainWindow : Window
    {
        private bool _savedChanges;
        
        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
            _savedChanges = true;
        }

        private MainWindow(Builder builder) : base(builder.GetObject("Main_ApplicationWindow").Handle)
        {
            builder.Autoconnect(this);
            InitializeComponents();
        }
        
        private void SaveChangesMenuItem_OnActivated(object sender, EventArgs e)
        {
            _savedChanges = true;
        }
        
        private void QuitMenuItem_OnActivated(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ConnDBMenuItem_OnActivated(object sender, EventArgs e)
        {
        }
        
        private void DisconnDBMenuItem_OnActivated(object sender, EventArgs e)
        {
        }
        
        private void ExecuteButton_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}