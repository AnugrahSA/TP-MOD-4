using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_130
{

<<<<<<< HEAD
=======
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
>>>>>>> generic-class

    internal class Program
    {
<<<<<<< HEAD
=======
            DataGeneric<String> data = new DataGeneric<string>("1302204047");
            data.PrintData();
>>>>>>> generic-class
        }
    }
}