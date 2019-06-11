using Gtk;

namespace Grasshoppers.Queries
{
    public class InventoryQueryForm : IQuery
    {
        private readonly InventoryQuery _query;

        public string Name => _query.Name;
        
        public ITreeModel Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}