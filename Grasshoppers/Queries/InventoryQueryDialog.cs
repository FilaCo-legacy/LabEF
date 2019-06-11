using Gtk;

namespace Grasshoppers.Queries
{
    public partial class InventoryQueryDialog : Dialog, IQuery, IQueryResult
    {
        private readonly InventoryQuery _query;

        public new string Name => _query.Name;

        public InventoryQueryDialog()
        {
            _query = new InventoryQuery();
        }

        public ITreeModel Execute() => _query.Execute();

        public TreeView GetResult()
        {
            var tree = new TreeView();

            tree.AppendColumn("Name", new CellRendererText(), "text", 0);
            tree.AppendColumn("Rarity", new CellRendererText(), "text", 1);
            tree.AppendColumn("Description", new CellRendererText(), "text", 2);
            tree.AppendColumn("Sprite", new CellRendererText(), "text", 3);

            tree.Model = Execute();

            return tree;
        }
    }
}