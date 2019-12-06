using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class ReciveOrderDetail : IDatabese
    {
        
        public string ReciveOrderDetailID { get; set; }
        public string ReciveOrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        
        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
