using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Maker : DataModel
    {
        [SerializeProperty("メーカーID", IsKey = true, RelationKey = true)]
        public string MakerID { get; set; }

        [SerializeProperty("メーカー名")] public string MakerName { get; set; }

        [SerializeProperty("電話番号")] public int PhoneNumber { get; set; }
        [SerializeProperty("FAX番号")] public string FaxNumber { get; set; }
        [SerializeProperty("住所")] public int Access { get; set; }
    }
}
