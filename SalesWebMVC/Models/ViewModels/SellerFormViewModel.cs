﻿using System.Collections;

namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departament> Departaments { get; set; }
    }
}
