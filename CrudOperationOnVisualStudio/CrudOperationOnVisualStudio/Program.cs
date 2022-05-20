using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationOnVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "localhost";
            string database = "kirandb1";
            string username = "root";
            string password = "kiran@992192";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            CrudOperation.create(constring);
            CrudOperation.insert(constring);
            CrudOperation.update(constring);
            CrudOperation.delete(constring);
            Console.WriteLine("CrudOperation");
            Console.ReadKey();
        }

    }
}
