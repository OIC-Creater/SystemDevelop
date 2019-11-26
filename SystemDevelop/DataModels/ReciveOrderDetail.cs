using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class ReciveOrderDetail : DataModel
    {
        [SerializeProperty("受注詳細ID", IsKey = true, RelationKey = true)]
        public string ReciveOrderDetailID { get; set; }

        [SerializeProperty("受注ID")] public string ReciveOrderID { get; set; }
        [SerializeProperty("商品ID")] public string ProductID { get; set; }
        [SerializeProperty("個数")] public int quantity { get; set; }

        [IgnoreProperty, UnionTarget("ReciveOrderID")]
        public ReciveOrder TReciveOrder { get; set; }
        [IgnoreProperty, UnionTarget("PrpductID")]
        public Product TProduct { get; set; }
    }
}
