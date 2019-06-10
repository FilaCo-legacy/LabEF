using System;
using System.Collections.Generic;
using System.Linq;
using GLib;
using Gtk;

namespace Grasshoppers
{
    internal partial class MainWindow : Window
    {
        private bool _savedChanges;

        private IList<IQuery> _queriesList;

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
            _queriesList = new List<IQuery>();
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
            Destroy();
        }
        
        private void ConnectDBMenuItem_OnActivated(object sender, EventArgs e)
        {
        }
        
        private void DisconnectDBMenuItem_OnActivated(object sender, EventArgs e)
        {
        }
        
        private void ExecuteButton_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}