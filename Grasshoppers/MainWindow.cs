using System;
using System.Collections.Generic;
using System.Linq;
using GLib;
using Grasshoppers.Queries;
using Gtk;

namespace Grasshoppers
{
    internal partial class MainWindow : Window
    {
        private bool _savedChanges;

        private IList<IGrasshoppersQuery> _queriesList;

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
            _queriesList = new List<IGrasshoppersQuery>();
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

        public void AddQuery(IGrasshoppersQuery query)
        {
            _queriesList.Add(query);
            
            Queries_ComboBoxText.AppendText(query.Name);
        }

        public void AddRangeQuery(IEnumerable<IGrasshoppersQuery> queries)
        {
            foreach (var cur in queries)
            {
                AddQuery(cur);
            }
        }
    }
}