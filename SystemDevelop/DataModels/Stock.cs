using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Stock : IDatabese
    {
        public string StockID { get; set; }
        public string ProductID { get; set; }
        public string StockAmount { get; set; }
        

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
