using System.Data.OleDb;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Affiliation : DataModel
    {
        [SerializePropertyAttribute("所属ID", IsKey=true, RelationKey=true)]
        public string AffiliationId{ get; set; }
        
        [SerializePropertyAttribute("所属名", IsKey=false, RelationKey=false)]
        public string AffiliationName
        { get; set; }
    }
}
