using System;
using System.Linq;
using GLib;
using Gtk;

namespace Grasshoppers
{
    internal partial class MainWindow : Window
    {
        private bool _savedChanges;

        private IQueriesProvider _queriesProvider;

        public IQueriesProvider QueriesProvider { get => _queriesProvider;
            set
            {
                Queries_ComboBoxText.Clear();
                var cellRendererText = new CellRendererText();
               
                Queries_ComboBoxText.PackStart(cellRendererText, true);
                Queries_ComboBoxText.AddAttribute(cellRendererText,"text", 0);

                foreach (var curQuery in value)
                {
                    Queries_ComboBoxText.AppendText(curQuery.Name);
                }
            }
        }
        
        public MainWindow(IQueriesProvider queriesProvider) : this(new Builder("MainWindow.glade"))
        {
            QueriesProvider = queriesProvider;
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