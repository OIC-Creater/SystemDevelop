using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDevelop.DataModels;

namespace SystemDevelop.Model.DB
{
    class Datasouce
    {
        public void SetDatasouce(Controller form)
        {
            BindingList<ReciveOrderDetail> reciveOrderDetails
                = new BindingList<ReciveOrderDetail>(DatabaseInstance.ReciveOrderDetailTable.ToArray());
            BindingList<SalesOffice>  salesOffices
                = new BindingList<SalesOffice>(DatabaseInstance.SalesOfficeTable.ToArray());
        }
    }
}
