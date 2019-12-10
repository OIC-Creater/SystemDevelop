using System.Data.OleDb;
using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Shop : DataModel
    {
        public OleDbConnection OleDb { get; set; }
        public string ShopID { get; set; }
        public string ShopName { get; set; }
        public int PhoneNumber { get; set; } 
        public int Access { get; set; } 
        public string FaxNumber { get; set; } 
        
        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
