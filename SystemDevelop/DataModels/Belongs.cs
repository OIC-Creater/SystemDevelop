using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Belongs : IDatabese
    {
        public string AffiliationID { get; set; } = "";
        public string AffiliationName { get; set; } = "";

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
