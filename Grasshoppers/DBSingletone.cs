using Grasshoppers.Models;

namespace Grasshoppers
{
    public class DbSingletone
    {
        private static readonly GrasshoppersContext Instance = new GrasshoppersContext();
        
        public static GrasshoppersContext Access => Instance;
    }
}