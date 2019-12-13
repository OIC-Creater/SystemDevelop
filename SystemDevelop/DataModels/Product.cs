using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Product : DataModel
    {
        [SerializePropertyAttribute("商品ID", IsKey = true, RelationKey = true)]
        public string ProductId { get; set; }

        [SerializePropertyAttribute("商品名", IsKey = false, RelationKey = false)]
        public string ProductName { get; set; }

        [SerializePropertyAttribute("メーカーID", IsKey=false, RelationKey=false)]
        public string MakerId { get; set; }
        
        [SerializePropertyAttribute("原価", IsKey=false, RelationKey=false)]
        public int Cost { get; set; }

        [SerializePropertyAttribute("売価", IsKey = false, RelationKey = false)]
        public int Price { get; set; }

        [SerializePropertyAttribute("設定ID", IsKey=false, RelationKey=false)]
        public string SettingId { get; set; }
        
        
        [IgnoreProperty, UnionTarget(nameof(DataModels.Maker.MakerId))]
        public Maker Maker { get; set; }
        [IgnoreProperty, UnionTarget(nameof(DataModels.Setting.SettingId))]
        public Setting Setting { get; set; }
    }
}
