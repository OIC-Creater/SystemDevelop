using System;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Storing : DataModel
    {
        [ObjectDatabase.SerializePropertyAttribute("担当者ID", IsKey = false, RelationKey = false)]
        public string EmployeeId { get; set; }

        [ObjectDatabase.SerializePropertyAttribute("入庫ID", IsKey=true, RelationKey=true)]
        public string StoringId { get; set; }
        
        [ObjectDatabase.SerializePropertyAttribute("入庫済みチェック", IsKey=false, RelationKey=false)]
        public bool StoringCheck { get; set; }
        
        [ObjectDatabase.SerializePropertyAttribute("入庫日", IsKey=false, RelationKey=false)]
        public DateTime Date { get; set; }
        
        [ObjectDatabase.SerializePropertyAttribute("発注明細ID", IsKey=false, RelationKey=false)]
        public string OrderDitailId { get; set; }
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Employee.EmployeeId))]
        public Employee Employee { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.OrderDetail.OrderDetailId))]
        public OrderDetail OrderDetail { get; set; }
    }
}