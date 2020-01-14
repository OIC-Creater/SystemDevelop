using ObjectDatabase;
using System.Runtime.Serialization;

namespace SystemDevelop.DataModels
{
    public class ReciveOrder : DataModel
    {
        [SerializePropertyAttribute("受注ID", IsKey = true, RelationKey = true)]
        public string ReciveOrderId { get; set; }

        [SerializePropertyAttribute("ショップID", IsKey=false, RelationKey=false)]
        public string ShopId { get; set; }
        
        [SerializePropertyAttribute("ハトID", IsKey=false, RelationKey=false)]
        public string PigeonId { get; set; }
        
        [SerializePropertyAttribute("営業所ID", IsKey=false, RelationKey=false)]
        public string SalesOfficeId { get; set; }
        
        [SerializePropertyAttribute("受注担当者ID", IsKey=false, RelationKey=false)]
        public string EmployeeId { get; set; }
        
        [SerializePropertyAttribute("受注日", IsKey=false, RelationKey=false)]
        public string Date { get; set; }
        
        [SerializePropertyAttribute("受領チェック", IsKey=false, RelationKey=false)]
        public bool ReceiptCheck { get; set; } 
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Shop.ShopId)),IgnoreDataMember]
        public Shop Shop { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.Pigeon.PigeonId)), IgnoreDataMember]
        public Pigeon Pigeon { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.SalesOffice.SalesOfficeId)), IgnoreDataMember]
        public SalesOffice SalesOffice { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.Employee.EmployeeId)), IgnoreDataMember]
        public Employee Employee { get; set; }



    }
}
