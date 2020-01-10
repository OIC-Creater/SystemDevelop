using System;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Storing : DataModel
    {
        [SerializePropertyAttribute("入庫ID", IsKey = true, RelationKey = true)]
        public string StoringId { get; set; }

        [SerializePropertyAttribute("発注明細ID", IsKey = false, RelationKey = false)]
        public string OrderDitailId { get; set; }

        [SerializePropertyAttribute("担当者ID", IsKey = false, RelationKey = false)]
        public string EmployeeId { get; set; }

        [SerializePropertyAttribute("入庫日", IsKey = false, RelationKey = false)]
        public DateTime Date { get; set; }

        [SerializePropertyAttribute("入庫済みチェック", IsKey=false, RelationKey=false)]
        public bool StoringCheck { get; set; }
        
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Employee.EmployeeId))]
        public Employee Employee { get; set; }

        [IgnoreProperty, UnionTarget(nameof(DataModels.OrderDetail.OrderDetailId))]
        public OrderDetail OrderDetail { get; set; }
    }
}