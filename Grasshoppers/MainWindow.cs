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
        private readonly IList<IGrQueryProvider> _queriesList;

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
            _queriesList = new List<IGrQueryProvider>();
        }

        private MainWindow(Builder builder) : base(builder.GetObject("Main_ApplicationWindow").Handle)
        {
            builder.Autoconnect(this);
            InitializeComponents();
        }
        
        private void QuitMenuItem_OnActivated(object sender, EventArgs e)
        {
            Destroy();
        }

        private void ExecuteButton_OnClicked(object sender, EventArgs e)
        {
            if (_queriesList.Count == 0) return;
            
            _queriesList[Queries_ComboBoxText.Active].GetResult();
        }

        public void AddQueryProvider(IGrQueryProvider queryProvider)
        {
            _queriesList.Add(queryProvider);
            
            Queries_ComboBoxText.AppendText(queryProvider.Query.Name);
        }

        public void AddRangeQueryProviders(IEnumerable<IGrQueryProvider> queryProviders)
        {
            foreach (var cur in queryProviders)
            {
                AddQueryProvider(cur);
            }
        }
    }
}