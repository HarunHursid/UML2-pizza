﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzastore
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }




    public override string ToString()
    { 
        return $"\n pizza navn: {Name}\n pizza id: {Number}\n pris: {Price}";
    
    
    
    
    }
     
    
    }
}

