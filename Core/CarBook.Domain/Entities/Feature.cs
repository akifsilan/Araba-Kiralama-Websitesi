﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Feature
    {
        public string Name { get; set; }
        public int FeatureID { get; set; }
        public List<CarFeature> CarFeatures { get; set; }

    }
}
