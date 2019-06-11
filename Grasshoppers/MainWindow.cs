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
        
        [ConnectBefore]
        private void CharactersTreeView_OnButtonPressed(object sender, ButtonPressEventArgs e)
        {
            if (e.Event.Button != 3) return;
            
            Characters_Menu.ShowAll();
            Characters_Menu.Popup();
        }

        [ConnectBefore]
        private void ItemsTreeView_OnButtonPressed(object sender, ButtonPressEventArgs e)
        {
            if (e.Event.Button != 3) return;
            
            Items_Menu.ShowAll();
            Items_Menu.Popup();
        }
        
        [ConnectBefore]
        private void MissionsTreeView_OnButtonPressed(object sender, ButtonPressEventArgs e)
        {
            if (e.Event.Button != 3) return;
            
            Missions_Menu.ShowAll();
            Missions_Menu.Popup();
        }
        
        [ConnectBefore]
        private void GameSessionsTreeView_OnButtonPressed(object sender, ButtonPressEventArgs e)
        {
            if (e.Event.Button != 3) return;
            
            GameSessions_Menu.ShowAll();
            GameSessions_Menu.Popup();
        }
        
        [ConnectBefore]
        private void CharactersResultsTreeView_OnButtonPressed(object sender, ButtonPressEventArgs e)
        {
            if (e.Event.Button != 3) return;
            
            CharactersResults_Menu.ShowAll();
            CharactersResults_Menu.Popup();
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