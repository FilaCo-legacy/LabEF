using Gtk;

namespace Grasshoppers.Queries
{
    public interface IGrQueryProvider
    {
        IQuery Query { get; }
        
        TreeView GetResult();
    }
}