using ObjectDatabase;
using System.Data.OleDb;
using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Product : IDatabese
    {
        public OleDbConnection OleDb { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public int Price { get; set; }
        public string MakerID { get; set; }
        public string SettingId { get; set; }
        

        public void Update() { }
        public void Get() { }
        public void Add() { }

    }
}
