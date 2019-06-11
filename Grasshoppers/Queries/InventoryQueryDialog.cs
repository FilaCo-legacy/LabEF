using Gtk;

namespace Grasshoppers.Queries
{
    public partial class InventoryQueryDialog : Dialog, IGrQueryProvider
    {
        private readonly InventoryQuery _query;

        public IQuery Query => _query;
        
        public InventoryQueryDialog() : this(new Builder("InventoryQueryDialog.glade"))
        {
            _query = new InventoryQuery();
        }

        private InventoryQueryDialog(Builder builder) : base(builder.GetObject("InventoryQuery_Dialog").Handle)
        {
            builder.Autoconnect(this);
            InitializeComponents();
        }

        public TreeView GetResult()
        {
            Modal = true;
            var response = (ResponseType)Run();

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