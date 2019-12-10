using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class ReciveOrder : IDatabese
    {
        public string ReciveOrderID { get; set; }
        public string BelongsID { get; set; }
        public string ShopID { get; set; }
        public string Date { get; set; }
        public string EmployeeID { get; set; }
        public string PigeonID { get; set; }

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
