﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.IntegrationViewModel
{
    public class SupplierViewModel
    {
        public string _id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public bool import { get; set; }
    }
}
