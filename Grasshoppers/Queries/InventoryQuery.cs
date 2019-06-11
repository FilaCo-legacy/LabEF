using Gtk;

namespace Grasshoppers.Queries
{
    public class InventoryQuery : IQuery
    {
        private int _characterId;
        
        public string Name => Resources.InventoryQuery_Name;

        public ITreeModel Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}