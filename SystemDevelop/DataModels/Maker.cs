using System.Data.OleDb;
using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Maker : DataModel
    {
        [SerializePropertyAttribute("FAX番号", IsKey=false, RelationKey=false)]
        public string FaxNumber { get; set; }
        
        [SerializePropertyAttribute("メーカーID", IsKey=true, RelationKey=true)]
        public string MakerId { get; set; }
        
        [SerializePropertyAttribute("メーカー名", IsKey=false, RelationKey=false)]
        public string MakerName { get; set; }
        
        [SerializePropertyAttribute("住所", IsKey=false, RelationKey=false)]
        public string Access { get; set; }
        
        [SerializePropertyAttribute("電話番号", IsKey=false, RelationKey=false)]
        public string PhoneNumber { get; set; }

    }
}