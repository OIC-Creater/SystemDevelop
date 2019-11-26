using ObjectDatabase;
namespace SystemDevelop.DataModels
{
    class Belongs : DataModel
    {
        [SerializeProperty("所属ID", IsKey = true, RelationKey = true)]
        public string BelongsID { get; set; }

        [SerializeProperty("所属名")] public string BelongsName { get; set; }
    }
}
