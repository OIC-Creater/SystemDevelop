using System.Data.OleDb;
using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Shop : DataModel
    {
        [SerializePropertyAttribute("FAX番号", IsKey=false, RelationKey=false)]
        public string FaxNumber { get; set; } 
        
        [SerializePropertyAttribute("ショップID", IsKey=true, RelationKey=true)]
        public string ShopId { get; set; }
        
        [SerializePropertyAttribute("ショップ名", IsKey=false, RelationKey=false)]
        public string ShopName { get; set; }
        
        [SerializePropertyAttribute("住所", IsKey=false, RelationKey=false)]
        public int Access { get; set; } 
        
        [SerializePropertyAttribute("電話番号", IsKey=false, RelationKey=false)]
        public int PhoneNumber { get; set; } 
    }
}
