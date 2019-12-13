using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Pigeon : DataModel
    {
        [SerializePropertyAttribute("ステータスID", IsKey=false, RelationKey=false)]
        public string StatusId { get; set; }
        
        [SerializePropertyAttribute("ハトID", IsKey=true, RelationKey=true)]
        public string PigeonId { get; set; }
        
        [SerializePropertyAttribute("ハト名", IsKey=false, RelationKey=false)]
        public string PigeonName { get; set; }
        
        [SerializePropertyAttribute("公開鍵", IsKey=false, RelationKey=false)]
        public string PublicKey { get; set; }
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Status.StatusId))]
        public Status Status { get; set; }
    }
}
