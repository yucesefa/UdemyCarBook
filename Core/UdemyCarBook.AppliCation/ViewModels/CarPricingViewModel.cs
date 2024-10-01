﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.AppliCation.ViewModels
{
    public class CarPricingViewModel
    {
        public CarPricingViewModel()
        {
            Amounts = new List<decimal>();
        }
        public string Model {  get; set; }
        public string CoverImageUrl { get; set; }
        public string Brand {  get; set; }
        public List<decimal> Amounts { get; set; }
    }
}
