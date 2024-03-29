﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsAndGarbage
{
    internal class NewAttribute : Attribute
    {
        private string title;
        private string description;
        public NewAttribute(string t, string d)
        {
            title = t;
            description = d;
        }
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType);
            MethodInfo[] methods = classType.GetMethods();
            for(int i = 0; i < methods.GetLength(0); i++)
            {
                object[] attributesArray = methods[i].GetCustomAttributes(true);
                foreach(Attribute item in attributesArray)
                {
                    if(item is NewAttribute)
                    {
                        NewAttribute attributeObject = (NewAttribute)item;
                        Console.WriteLine("{0} - {1}, {2}", methods[i].Name, attributeObject.title, attributeObject.description);
                    }
                }
            }
        }
    }
}
