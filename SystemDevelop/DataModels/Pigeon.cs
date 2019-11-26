using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Pigeon : DataModel
    {
        [SerializeProperty("ハトID", IsKey = true, RelationKey = true)]
        public string PigeonID { get; set; }

        [SerializeProperty("ハト名")] public string PigeonName { get; set; }

        [SerializeProperty("公開鍵")] public string PublicKey { get; set; }
        [SerializeProperty("ステータスID")] public string StatusID { get; set; }
    }
}
