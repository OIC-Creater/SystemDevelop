using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Maker : IDatabese
    {
        public string MakerID { get; set; }
        public string MakerName { get; set; }
        public int PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public int Access { get; set; }

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}