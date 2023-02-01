using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;
namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMyList<int> MyList = new ClassMyList<int>();
            MyList.Add(5);
            int count = MyList.Count;
        }
    }
}
