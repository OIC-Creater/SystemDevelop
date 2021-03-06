﻿using ObjectDatabase;
using System.Runtime.Serialization;

namespace SystemDevelop.DataModels
{
    public class ReciveOrderDetail : DataModel
    {
        [SerializePropertyAttribute("受注明細ID", IsKey = true, RelationKey = true)]
        public string ReciveOrderDetailId { get; set; }

        [SerializePropertyAttribute("受注ID", IsKey = false, RelationKey = false)]
        public string ReciveOrderId { get; set; }

        [SerializePropertyAttribute("商品ID", IsKey = false, RelationKey = false)]
        public string ProductId { get; set; }

        [SerializePropertyAttribute("個数", IsKey=false, RelationKey=false)]
        public int Quantity { get; set; } 
        

        [IgnoreProperty, UnionTarget(nameof(DataModels.ReciveOrder.ReciveOrderId)),IgnoreDataMember]
        public ReciveOrder ReciveOrder { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.Product.ProductId)),IgnoreDataMember]
        public Product Product { get; set; }
    }
}
