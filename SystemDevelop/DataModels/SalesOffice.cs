using System.Data.OleDb;
using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class SalesOffice : DataModel
    {
        [SerializePropertyAttribute("FAX番号", IsKey=false, RelationKey=false)]
        public string FaxNumber { get; set; } 
        
        [SerializePropertyAttribute("営業所ID", IsKey=true, RelationKey=true)]
        public string SalesOfficeId { get; set; } 
        
        [SerializePropertyAttribute("営業所名", IsKey=false, RelationKey=false)]
        public string SalesOfficeName { get; set; } 
        
        [SerializePropertyAttribute("住所", IsKey=false, RelationKey=false)]
        public int Access { get; set; } 
        
        [SerializePropertyAttribute("電話番号", IsKey=false, RelationKey=false)]
        public int PhoneNumber { get; set; } 
    }
}
