using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Setting : DataModel
    {
        [ObjectDatabase.SerializePropertyAttribute("設定ID", IsKey=true, RelationKey=true)]
        public string SettingId { get; set; }
        
        [ObjectDatabase.SerializePropertyAttribute("発注点", IsKey=false, RelationKey=false)]
        public int ReorderPoint{ get; set; }
        
        [ObjectDatabase.SerializePropertyAttribute("発注量", IsKey=false, RelationKey=false)]
        public int OrderQuantity { get; set; }
    }
}