using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Employee : DataModel
    {
       [SerializePropertyAttribute("パスワード", IsKey=false, RelationKey=false)]
        public string Password { get; set; }
        
        [SerializePropertyAttribute("ハトID", IsKey=false, RelationKey=false)]
        public string PigeonId { get; set; } 
        
        [SerializePropertyAttribute("雇用中", IsKey=false, RelationKey=false)]
        public bool WorkingFlag { get; set; }
        
        [SerializePropertyAttribute("社員ID", IsKey=true, RelationKey=true)]
        public string EmployeeId { get; set; } 
        
        [SerializePropertyAttribute("社員名", IsKey=false, RelationKey=false)]
        public string EmployeeName { get; set; } 
        
        [SerializePropertyAttribute("所属ID", IsKey=false, RelationKey=false)]
        public string AffiliationId { get; set; } 
        
        [SerializePropertyAttribute("電話番号", IsKey=false, RelationKey=false)]
        public string PhoneNumber { get; set; } 
        
        [SerializePropertyAttribute("名前カナ", IsKey=false, RelationKey=false)]
        public string EmployeeKatakana { get; set; }

        [IgnoreProperty, UnionTarget(nameof(DataModels.Pigeon.PigeonId))]
        public Pigeon Pigeon { get; set; }

        [IgnoreProperty, UnionTarget(nameof(DataModels.Affiliation.AffiliationId))]
        public Affiliation Affiliation { get; set; }
        
    }
}
