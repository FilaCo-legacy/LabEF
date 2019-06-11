using Gtk;

namespace Grasshoppers.Queries
{
    public partial class InventoryGrQueryDialog : Dialog, IGrQueryProvider
    {
        private readonly InventoryQuery _query;

        public IQuery Query => _query;

        public InventoryGrQueryDialog()
        {
            _query = new InventoryQuery();
        }

        public TreeView GetResult()
        {
            var tree = new TreeView();

            tree.AppendColumn("Name", new CellRendererText(), "text", 0);
            tree.AppendColumn("Rarity", new CellRendererText(), "text", 1);
            tree.AppendColumn("Description", new CellRendererText(), "text", 2);
            tree.AppendColumn("Sprite", new CellRendererText(), "text", 3);

            tree.Model = _query.Execute();

            return tree;
        }
    }
}