using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool HasFeathers { get; set; }
        
        public Bird(string name, int age, int legs, int wings, bool hasBackbone, bool isWarmBlooded, bool hasFeathers)
          {
            Name = name;
            Age = Age;
            Legs = legs;
            HasBackbone = hasBackbone;
            IsWarmBlooded = isWarmBlooded;
            HasFeathers = hasFeathers;
            Wings = wings;
            
            
          }
}
}
