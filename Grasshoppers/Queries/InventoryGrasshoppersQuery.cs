using Gtk;

namespace Grasshoppers.Queries
{
    public class InventoryGrasshoppersQuery : IGrasshoppersQuery
    {
        public string Name => Resources.InventoryGrasshoppersQuery_Name;

        public ITreeModel Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}