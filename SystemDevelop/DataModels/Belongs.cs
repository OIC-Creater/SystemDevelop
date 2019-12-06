using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class Belongs : IDatabese
    {
        public string BelongsID { get; set; }
        public string BelongsName { get; set; }

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
