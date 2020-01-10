using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class OrderDetail : DataModel
    {
        [SerializePropertyAttribute("発注明細ID", IsKey = true, RelationKey = true)]
        public string OrderDetailId { get; set; }

        [SerializePropertyAttribute("発注ID", IsKey = false, RelationKey = false)]
        public string OrderId { get; set; }

        [SerializePropertyAttribute("商品ID", IsKey = false, RelationKey = false)]
        public string ProductId { get; set; }

        [SerializePropertyAttribute("個数", IsKey = false, RelationKey = false)]
        public int Quantity { get; set; }
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Product.ProductId))]
        public Product Product { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.Order.OrderId))]
        public Order Order { get; set; }
    }
}