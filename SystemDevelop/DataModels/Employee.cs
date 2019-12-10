using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    public class Employee : DataModel
    {
        public string EmployeeID { get; set; } 
        public string EmployeeName { get; set; } 
        public string EmployeeKatakana { get; set; } 
        public string AffiliationID { get; set; } 
        public string Password { get; set; } 
        public string PhoneNumber { get; set; } 
        public string PigeonID { get; set; } 
        public bool NowWork { get; set; } 
        
       

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
