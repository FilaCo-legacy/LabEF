using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Grasshoppers
{
    internal partial class MainWindow
    {
        #region AppMenuItems
        
        [UI] private MenuItem ConnDB_MenuItem;

        [UI] private MenuItem DisconnDB_MenuItem;

        [UI] private MenuItem SaveChanges_MenuItem;

        [UI] private MenuItem Quit_MenuItem;

        #endregion

        #region TreeViews
        
        [UI] private TreeView Characters_TreeView;
        
        [UI] private TreeView Items_TreeView;

        [UI] private TreeView GameSessions_TreeView;

        [UI] private TreeView Missions_TreeView;

        [UI] private TreeView CharactersResults_TreeView;

        #endregion

        [UI] private ComboBox Queries_ComboBox;

        [UI] private Button Execute_Button;
        
        private void InitializeComponents()
        {
            Quit_MenuItem.Activated += QuitMenuItem_OnActivated;
            SaveChanges_MenuItem.Activated += SaveChangesMenuItem_OnActivated;
            ConnDB_MenuItem.Activated += ConnDBMenuItem_OnActivated;
            DisconnDB_MenuItem.Activated += DisconnDBMenuItem_OnActivated;

            Execute_Button.Clicked += ExecuteButton_OnClicked;
        }
    }
}