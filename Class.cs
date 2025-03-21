using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._21._03._25
{
   public class ClassA
    {
        public void MethodA(ClassB classB)
        {
            classB.MethodB(this);
        }
        public void Add( ref int a)// ref - передаем по ссылке
    {
        a++;
    }
    }
   
    public class ClassB
    {
        public void MethodB(ClassA classA)
        {
            Console.WriteLine("Hello");
        }
    }
}

namespace Engine
{
    namespace Renderer
    {
        class Vector3D { }
    }
    namespace Physics
    {
        class Vector3D { }
    }
}