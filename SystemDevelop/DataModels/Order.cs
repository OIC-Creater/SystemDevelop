using System;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Order : DataModel
    {
        [SerializePropertyAttribute("発注ID", IsKey = true, RelationKey = true)]
        public string OrderId { get; set; }

        [SerializePropertyAttribute("発注担当ID", IsKey = false, RelationKey = false)]
        public string EmployeeId { get; set; }

        [SerializePropertyAttribute("発注日", IsKey=false, RelationKey=false)]
        public DateTime 発注日 { get; set; }

        [IgnoreProperty, UnionTarget(nameof(DataModels.Employee.EmployeeId))]
        public Employee Employee { get; set; }
    }
}