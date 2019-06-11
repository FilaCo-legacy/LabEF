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
        private readonly IList<IQuery> _queriesList;

        public MainWindow() : this(new Builder("MainWindow.glade"))
        {
            _queriesList = new List<IQuery>();
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
            
            _queriesList[Queries_ComboBoxText.Active].Execute();
        }

        public void AddQuery(IQuery query)
        {
            _queriesList.Add(query);
            
            Queries_ComboBoxText.AppendText(query.Name);
        }

        public void AddRangeQuery(IEnumerable<IQuery> queries)
        {
            foreach (var cur in queries)
            {
                AddQuery(cur);
            }
        }
    }
}