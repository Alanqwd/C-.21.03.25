using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_._21._03._25
{
   public struct Car
    {
        public int _VIN;
        public int _NEngine;
        public string _Brand;
        public string _Model;
        public int _Year;
        public string _Color;


        
        public string Info
        {

            get 
            { 
                return $" ( vin: {_VIN}, brand: {_Brand}, model: {_Model}, year: {_Year}, color: {_Color}, number engine: {_NEngine}"; 
            }


        }
        public bool VIN (int vin)
        {
            return _VIN == vin;

        }
    }

}
