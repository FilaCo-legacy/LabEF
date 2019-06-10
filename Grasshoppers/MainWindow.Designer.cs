using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Grasshoppers
{
    internal partial class MainWindow
    {
        #region AppMenuItems
        
        [UI] private MenuItem ConnDBItem_MenuItem;

        [UI] private MenuItem DisconnDBItem_MenuItem;

        [UI] private MenuItem SaveChangesItem_MenuItem;

        [UI] private MenuItem QuitItem_MenuItem;

        #endregion

        #region TreeViews
        
        [UI] private TreeView CharactersView_TreeView;
        
        [UI] private TreeView ItemsView_TreeView;

        [UI] private TreeView GameSessionsView_TreeView;

        [UI] private TreeView MissionsView_TreeView;

        [UI] private TreeView CharactersResultsView_TreeView;

        #endregion

        [UI] private ComboBox QueriesList_ComboBox;

        [UI] private Button Execute_Button;
        
        private void InitializeComponents()
        {
            QuitItem_MenuItem.Activated += QuitItem_OnActivate;
            
            
        }
    }
}