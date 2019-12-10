using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Stock : DataModel
    {
        public string StockID { get; set; }
        public string ProductID { get; set; }
        public int StockAmount { get; set; }
        

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
