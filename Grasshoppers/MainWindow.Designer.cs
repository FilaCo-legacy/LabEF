using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace Grasshoppers
{
    internal partial class MainWindow
    {
        [UI] private MenuItem Quit_MenuItem;

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