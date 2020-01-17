using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Stock : DataModel
    {
        [SerializePropertyAttribute("在庫ID", IsKey=true, RelationKey=true)]
        public string StockId { get; set; }

        [SerializePropertyAttribute("在庫数", IsKey=false, RelationKey=false)]
        public int StockAmount { get; set; }
    }
}
