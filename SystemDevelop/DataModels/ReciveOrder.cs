using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class ReciveOrder : DataModel
    {
        [SerializeProperty("受注ID", IsKey = true, RelationKey = true)]
        public string ReciveOrderID { get; set; }

        [SerializeProperty("営業所ID")] public string BelongsID { get; set; }
        [SerializeProperty("ショップID")] public string ShopID { get; set; }
        [SerializeProperty("日付")] public string Date { get; set; }
        [SerializeProperty("担当者ID")] public string EmployeeID { get; set; }
        [SerializeProperty("ハトID")] public string PigeonID { get; set; }


        [IgnoreProperty, UnionTarget("BelongsID")]
        public Belongs TBelongs { get; set; }

        [IgnoreProperty, UnionTarget("ShopID")]
        public Shop TShop { get; set; }

        [IgnoreProperty, UnionTarget("EmployeeID")]
        public Employee TEmployee { get; set; }

        [IgnoreProperty, UnionTarget("PigeonID")]
        public Pigeon TPigeon { get; set; }
    }
}
