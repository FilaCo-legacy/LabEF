namespace Grasshoppers
{
    public interface IQuery
    {
        string Name { get; set; }
        
        object Execute();
    }
}