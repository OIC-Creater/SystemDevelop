﻿using SystemDevelop.Interface;
using ObjectDatabase;

namespace SystemDevelop.DataModels
{
    class Status : DataModel
    {
        public string StatusID { get; set; } 
        public string StatusDetail { get; set; }

        public void Update() { }
        public void Get() { }
        public void Add() { }
    }
}
