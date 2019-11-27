using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Stock : DataModel
    {
        [SerializeProperty("在庫ID", IsKey = true, RelationKey = true)]
        public string StockID { get; set; }

        [SerializeProperty("商品ID")] public string ProductID { get; set; }
        [SerializeProperty("在庫数")] public string StockAmount { get; set; }

        [IgnoreProperty, UnionTarget("PrpductID")]
        public Product TProduct { get; set; }
    }
}
