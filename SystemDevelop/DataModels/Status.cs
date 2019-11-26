using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Status : DataModel
    {
        [SerializeProperty("ステータスID", IsKey = true, RelationKey = true)]
        public string StatusID { get; set; }

        [SerializeProperty("ステータス")] public string StatusDetail { get; set; }
    }
}
