﻿using System;
using System.Reflection;

namespace Base_Class_Attribute
{
    class Program
    {
        static void Main()
        {
            // MemberInfo - abstract class for getting information about class members. 
            //Type type = typeof(MyClass);
            MemberInfo type = typeof(MyClass);

            // GetCustomAttributes() - returns objects array of objects which are boxed attributes
            // getting from arrey elements Types of - MyAttribute.
            object[] attributes = type.GetCustomAttributes(typeof(MyAttribute), true); // true - also base class attributes

            if (attributes.GetLength(0) != 0)
            {
                foreach (MyAttribute attribute in attributes)
                {
                    Console.WriteLine(attribute.Text);
                    Console.WriteLine(attribute.Data);
                    attribute.Method();
                }
            }

            Console.ReadKey();
        }
    }
}
