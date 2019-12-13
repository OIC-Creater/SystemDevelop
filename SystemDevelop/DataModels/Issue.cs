using System;
using System.Data;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Issue : DataModel
    {
        [SerializePropertyAttribute("受注明細ID", IsKey=false, RelationKey=false)]
        public string ReciveOrderDetailId { get; set; } 
        
        [SerializePropertyAttribute("出庫ID", IsKey=true, RelationKey=true)]
        public string IssueId { get; set; }
        
        [SerializePropertyAttribute("出庫済みチェック", IsKey=false, RelationKey=false)]
        public bool IssueCheck { get; set; }
        
        [SerializePropertyAttribute("出庫担当者ID", IsKey=false, RelationKey=false)]
        public string EmployeeId{ get; set; }

        [SerializePropertyAttribute("日付", IsKey = false, RelationKey = false)]
        public DateTime Date { get; set; }
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.ReciveOrderDetail.ReciveOrderDetailId))]
        public  ReciveOrderDetail ReciveOrderDetail { get; set; }
    }
}