using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Status : IDatabese
    {
        public string StatusID { get; set; } = "";
        public string StatusDetail { get; set; } = "";

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
