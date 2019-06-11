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

        #region ContextMenus

        private Gtk.Menu Characters_Menu;
        
        private Gtk.Menu Items_Menu;
        
        private Gtk.Menu GameSessions_Menu;
        
        private Gtk.Menu Missions_Menu;
        
        private Gtk.Menu CharactersResults_Menu;

        #endregion
        
        private void InitializeComponents()
        {
            Quit_MenuItem.Activated += QuitMenuItem_OnActivated;

            Execute_Button.Clicked += ExecuteButton_OnClicked;

            var cellText = new CellRendererText();
            
            Queries_ComboBoxText.PackStart(cellText, false);
            Queries_ComboBoxText.AddAttribute(cellText, "text", 0);

            Characters_TreeView.ButtonPressEvent += CharactersTreeView_OnButtonPressed;
            
            Items_TreeView.ButtonPressEvent += ItemsTreeView_OnButtonPressed;
            
            GameSessions_TreeView.ButtonPressEvent += GameSessionsTreeView_OnButtonPressed;
            
            Missions_TreeView.ButtonPressEvent += MissionsTreeView_OnButtonPressed;
            
            CharactersResults_TreeView.ButtonPressEvent += CharactersResultsTreeView_OnButtonPressed;
            
            InitializeContextMenus();
        }

        private void InitializeContextMenus()
        {
            Characters_Menu = new Menu(); 
            Characters_Menu.Add(new MenuItem("Add"));
            
            Items_Menu = new Menu(); 
            Items_Menu.Add(new MenuItem("Add"));
            
            GameSessions_Menu = new Menu();
            GameSessions_Menu.Add(new MenuItem("Add"));
            
            Missions_Menu = new Menu();
            Missions_Menu.Add(new MenuItem("Add"));
            
            CharactersResults_Menu = new Menu();
            CharactersResults_Menu.Add(new MenuItem("Add"));
        }

        protected override void OnDestroyed()
        {
            Application.Quit();
            
            base.OnDestroyed();
        }
    }
}