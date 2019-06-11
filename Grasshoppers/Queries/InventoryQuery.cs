using Gtk;
using System.Linq;
using Grasshoppers.Models;

namespace Grasshoppers.Queries
{
    public class InventoryQuery : IQuery
    {
        public int CharacterId { get; set; }
        
        public string Name => Resources.InventoryQuery_Name;

        public ITreeModel Execute()
        {
            var db = DbSingletone.Access;

            var queryResult = (from inventoryEntry in db.Inventories
                where inventoryEntry.PlayerId == CharacterId
                select inventoryEntry.Item).ToList();

            var itemStore = new ListStore(typeof(string), typeof(string), typeof(ItemRarity), typeof(string));

            itemStore.AppendValues(queryResult);

            return itemStore;
        }
    }
}