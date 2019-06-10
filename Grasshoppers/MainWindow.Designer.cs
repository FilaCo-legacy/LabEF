using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Grasshoppers
{
    internal partial class MainWindow
    {
        #region AppMenuItems
        
        [UI] private MenuItem ConnectDB_MenuItem;

        [UI] private MenuItem DisconnectDB_MenuItem;

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

        [UI] private ComboBoxText Queries_ComboBoxText;

        [UI] private Button Execute_Button;
        
        private void InitializeComponents()
        {
            Quit_MenuItem.Activated += QuitMenuItem_OnActivated;
            SaveChanges_MenuItem.Activated += SaveChangesMenuItem_OnActivated;
            ConnectDB_MenuItem.Activated += ConnectDBMenuItem_OnActivated;
            DisconnectDB_MenuItem.Activated += DisconnectDBMenuItem_OnActivated;

            Execute_Button.Clicked += ExecuteButton_OnClicked;

            var cellText = new CellRendererText();
            
            Queries_ComboBoxText.PackStart(cellText, false);
            Queries_ComboBoxText.AddAttribute(cellText, "text", 0);
        }

        protected override void OnDestroyed()
        {
            Application.Quit();
            
            base.OnDestroyed();
        }
    }
}