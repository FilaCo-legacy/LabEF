using Gtk;

namespace Grasshoppers.Queries
{
    public interface IGrasshoppersQuery
    {
        string Name { get; set; }
        
        ITreeModel Execute();
    }
}