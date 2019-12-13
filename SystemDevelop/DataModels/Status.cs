using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Status : DataModel
    {
        [SerializePropertyAttribute("ステータスID", IsKey = true, RelationKey = true)]
        public string StatusId { get; set; }

        [SerializePropertyAttribute("ステータス", IsKey=false, RelationKey=false)]
        public string StatusDetail { get; set; }
    }
}
