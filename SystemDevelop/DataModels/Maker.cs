using System.Data.OleDb;
using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Maker : DataModel
    {
        public OleDbConnection OleDb { get; set; }
        public string MakerId { get; set; }
        public string MakerName { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Access { get; set; }

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}