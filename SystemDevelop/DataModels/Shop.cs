using System.Data.OleDb;
using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Shop : IDatabese
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
