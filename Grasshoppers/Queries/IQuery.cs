using Gtk;

namespace Grasshoppers.Queries
{
    public interface IQuery
    {
        string Name { get; }
        
        ITreeModel Execute();
    }
}