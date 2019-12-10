using System.Data.OleDb;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Affiliation : DataModel
    {
        [SerializeProperty("所属ID",RelationKey = true,IsKey = true)]
        public string AffiliationID { get; set; }
        [SerializeProperty("所属名")]public string AffiliationName { get; set; }

    }
}
