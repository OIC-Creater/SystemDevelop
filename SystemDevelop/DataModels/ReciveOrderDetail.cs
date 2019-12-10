using System.Data.OleDb;
using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class ReciveOrderDetail : DataModel
    {
        public OleDbConnection OleDb { get; set; }
        public string ReciveOrderDetailID { get; set; } 
        public string ReciveOrderID { get; set; } 
        public string ProductID { get; set; } 
        public int Quantity { get; set; } 
        
        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
