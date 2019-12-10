using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Stock : IDatabese
    {
        public OleDbConnection OleDb { get; set; }
        public string StockID { get; set; }
        public string ProductID { get; set; }
        public int StockAmount { get; set; }
        

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
