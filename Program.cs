using System.Text;
using Engine.Renderer;
namespace C_._21._03._25
{



    internal class Program
    {



        static void Main(string[] args)
        {/*
            People people = new People("Вася", "Петров", "Александрович");
            Console.WriteLine(people.FIO());*/

            Cat cat = new Cat("Мурзик", 6.5, true);
            cat.Name = null;
            Console.WriteLine(cat.Name);
            cat.Color = "желтый";
            cat.Meow();
            Console.WriteLine(cat.GetInfo());
            Console.WriteLine(cat.Color);

            /*  int a = 1;
              ClassA classA = new ClassA();
              classA.Add(ref a);
              Console.WriteLine(a);*/


            Engine.Physics.Vector3D vector3D1 = new Engine.Physics.Vector3D();
            Vector3D vector3D = new Vector3D();

        }
    }


    // [модификатор доступа] struct [название] {}
    //
    //
}
