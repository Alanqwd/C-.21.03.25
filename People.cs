using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._21._03._25
{


    public struct People
    {


       public string name;
       public string surname;
       public string patronymic;



    public People(string name, string surname, string patronymic)
        {

            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;

        }
    public string FIO()
        {
            return $"Фамилия: {surname}, Имя: {name}, Отчество: {patronymic}";

        }

    }

}
