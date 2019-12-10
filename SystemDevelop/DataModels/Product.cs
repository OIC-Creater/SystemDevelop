using ObjectDatabase;
using System.Data.OleDb;
using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Product : DataModel
    {
        [SerializeProperty("商品ID",RelationKey = true,IsKey = true)]
        public string ProductID { get; set; }
        
        [SerializeProperty("商品名")] public string ProductName { get; set; }
        [SerializeProperty("原価")] public int Cost { get; set; }
        [SerializeProperty("売価")] public int Price { get; set; }
        [SerializeProperty("メーカーID")] public string MakerID { get; set; }
        [SerializeProperty("設定ID")] public string SettingId { get; set; }

        [IgnoreProperty, UnionTarget(nameof(Maker.MakerId))]
        public Maker Maker { get; set; }
        /*[IgnoreProperty, UnionTarget(nameof(Setting.SettingId))]
        public Setting Setting { get; set; }*/
    }
}
