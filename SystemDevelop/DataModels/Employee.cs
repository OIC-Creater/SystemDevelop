using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Employee : DataModel
    {
        [SerializeProperty("社員ID", IsKey = true, RelationKey = true)]
        public string EmployeeID { get; set; }

        [SerializeProperty("社員名")] public string EmployeeName { get; set; }
        [SerializeProperty("電話番号")] public string PhoneNumber { get; set; }
        [SerializeProperty("パスワード")] public string Password { get; set; }
        [SerializeProperty("雇用中")] public string NowWork { get; set; }
        [SerializeProperty("所属ID")] public string BelongsID { get; set; }
        [SerializeProperty("ハトID")] public string PigeonID { get; set; }

        [IgnoreProperty, UnionTarget("BelongsID")]
        public Belongs TBelongs { get; set; }
        [IgnoreProperty, UnionTarget("PigeonID")]
        public Pigeon TPigeon { get; set; }
    }
}
