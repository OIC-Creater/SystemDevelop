using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Pigeon : IDatabese
    {
        public string PigeonID { get; set; }
        public string PigeonName { get; set; }
        public string PublicKey { get; set; }
        public string StatusID { get; set; }

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
