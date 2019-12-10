using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Pigeon : DataModel
    {
        public string Pigeon_ID { get; set; } = "";
        public string PigeonName { get; set; } = "";
        public string PublicKey { get; set; } = "";
        public string StatusID { get; set; } = "";

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
