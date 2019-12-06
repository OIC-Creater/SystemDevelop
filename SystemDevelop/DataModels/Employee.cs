using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    public class Employee : IDatabese
    {
        public string ID { get; set; } = "";
        public string Name { get; set; } = "";
        public string Password { get; set; } = "";
        public int BelongsID { get; set; } = 0;
        public string PhoneNumber { get; set; } = "";
        public string NowWork { get; set; } = "";
        public string PigeonID { get; set; } = "";

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
