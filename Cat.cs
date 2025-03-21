using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._21._03._25
{
    public class Cat
    {
        private string _name;
        private double _weight;
        private bool _sex;

        public string Name {
            get { return _name; }
            set {
                if (value != null) _name = value;
                else _name = "Кот";
            }

        }

        public string Color {get; set; }
        public Cat() { }
        public Cat(string name) 
            : this(name, 0, true ) {}
        public Cat(string name, double weight) 
            : this(name, weight, false) { }

        public Cat(string name, double weight, bool sex)
        {
            _name = name;
            _sex = sex;
            _weight = weight;   
        }

        public void Meow()
        {
            Console.WriteLine("Мяу");

        }

        public string GetInfo()
        {
            var sex = _sex ? "мальчик" : "девочка";
            return $"Кличка котика: {_name}, Вес: {_weight}, Пол: {_sex}";
        }
    }
}
