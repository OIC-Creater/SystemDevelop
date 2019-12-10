using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class SalesOffice : IDatabese
    {
        public string SalesOfficeID { get; set; } 
        public string SalesOfficeName { get; set; } 
        public int PhoneNumber { get; set; } 
        public int Access { get; set; } 
        public string FaxNumber { get; set; } 

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
