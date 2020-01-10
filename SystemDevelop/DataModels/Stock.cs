using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Stock : DataModel
    {
        [SerializePropertyAttribute("在庫ID", IsKey=true, RelationKey=true)]
        public string StockId { get; set; }

        [SerializePropertyAttribute("商品ID", IsKey = false, RelationKey = false)]
        public string ProductId { get; set; }

        [SerializePropertyAttribute("在庫数", IsKey=false, RelationKey=false)]
        public int StockAmount { get; set; }
        
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Product.ProductId))]
        public Product Product { get; set; }
    }
}
