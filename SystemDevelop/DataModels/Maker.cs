using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Maker : IDatabese
    {
        public string Maker_ID { get; set; } = "";
        public string Maker_Name { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string FaxNumber { get; set; } = "";
        public string Access { get; set; } = "";

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}