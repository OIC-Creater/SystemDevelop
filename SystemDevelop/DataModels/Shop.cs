using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Shop : DataModel
    {
        [SerializeProperty("ショップID", IsKey = true, RelationKey = true)]
        public string ShopID { get; set; }

        [SerializeProperty("ショップ名")] public string ShopName { get; set; }

        [SerializeProperty("電話番号")]public int PhoneNumber { get; set; }
        [SerializeProperty("住所")]public int Access { get; set; }
        [SerializeProperty("FAX番号")]public string FaxNumber { get; set; }
    }
}
