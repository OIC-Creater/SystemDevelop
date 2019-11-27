using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Product : DataModel
    {
        [SerializeProperty("商品ID", IsKey = true, RelationKey = true)]
        public string ProductID { get; set; }

        [SerializeProperty("商品名")] public string ProductName { get; set; }

        [SerializeProperty("原価")] public int Cost { get; set; }
        [SerializeProperty("売価")] public int Price { get; set; }

        [SerializeProperty("メーカーID")] public string MakerID { get; set; }
        [SerializeProperty("設定ID")] public string SettingId { get; set; }

        [IgnoreProperty, UnionTarget("MekerID")]
        public Maker TMaker { get; set; }
        /*[IgnoreProperty, UnionTarget("SettingID")]
        public Setting TSetting { get; set; }*/

    }
}
