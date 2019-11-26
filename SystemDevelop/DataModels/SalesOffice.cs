using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class SalesOffice :DataModel
    {
        [SerializeProperty("営業所ID", IsKey = true, RelationKey = true)]
        public string SalesOfficeID { get; set; }

        [SerializeProperty("営業所名")] public string SalesOfficeName { get; set; }

        [SerializeProperty("電話番号")] public int PhoneNumber { get; set; }
        [SerializeProperty("住所")] public int Access { get; set; }
    }
}
