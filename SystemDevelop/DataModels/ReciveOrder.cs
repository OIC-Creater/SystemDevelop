﻿using SystemDevelop.Interface;

namespace SystemDevelop.DataModels
{
    class ReciveOrder : IDatabese
    {
        public string ReciveOrderID { get; set; } = "";
        public string BusinessOfficeID { get; set; } = "";
        public bool ReceiptCheckID { get; set; } 
        public string ShopID { get; set; } = "";
        public string DateID { get; set; } = "";
        public string EmployeeResponsibleID { get; set; } = "";
        public string PigeonID { get; set; } = "";
        public string EmployeeID { get; set; } = "";

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
