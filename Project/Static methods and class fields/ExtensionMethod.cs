using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_methods_and_class_fields_Extension
{
    static class ExtensionMethod
        {
            public static void Print(this DateTime dateTime)
                { 
                    Console.WriteLine(dateTime);
                }
        }
}
