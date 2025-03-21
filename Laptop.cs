using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace C_._21._03._25
{


    public class Laptop
    {
        private string _model;
        private float _frequency;
        private int _amountRam;
        private int _amountHardRam;
        private float _weight;



        public Laptop(string model, float frequency , int amountRam, int amountHardRam, float weight)
        {

            this._model = model;
            this._frequency = frequency;
            this._amountRam = amountRam;
            this._amountHardRam = amountHardRam;
            this._weight = weight;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Модель: {_model}, Тактовая частота процессора: {_frequency}, Объем оп: {_amountRam}, Объем жд: {_amountHardRam}, Вес: {_weight}");

        }

    }
}
