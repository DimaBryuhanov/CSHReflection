using CSHReflection.Models;
using System;
using System.Reflection;

namespace CSHReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Customer);

            //Getting a class's properties:
            PropertyInfo[] propertyInfo = type.GetProperties();
            Console.WriteLine("The list of properties of the Customer class are:--");
            foreach (PropertyInfo pInfo in propertyInfo)
            {
                Console.WriteLine(pInfo.Name);
            }
            Console.WriteLine("\n");

            //Getting class's constructors:
            ConstructorInfo[] constructorInfo = type.GetConstructors();
            Console.WriteLine("The Customer class contains the following Constructors:--");
            foreach (ConstructorInfo c in constructorInfo)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\n");

            MethodInfo[] methodInfo = type.GetMethods();
            Console.WriteLine("The methods of the Customer class are:--");
            foreach (MethodInfo temp in methodInfo)
            {
                Console.WriteLine(temp.Name);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Methods' Attributes:");
            foreach (MethodInfo temp in methodInfo)
            {
                foreach (Attribute attribute in temp.GetCustomAttributes(true))
                {
                    Console.WriteLine(attribute);
                }
            }


            Console.Read();

        }
    }
}
