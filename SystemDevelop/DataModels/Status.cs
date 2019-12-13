using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Status : DataModel
    {
       
        
        [ObjectDatabase.SerializePropertyAttribute("ステータス", IsKey=false, RelationKey=false)]
        public string StatusDetail { get; set; }
        
        [ObjectDatabase.SerializePropertyAttribute("ステータスID", IsKey=true, RelationKey=true)]
        public string StatusId { get; set; } 
    }
}
