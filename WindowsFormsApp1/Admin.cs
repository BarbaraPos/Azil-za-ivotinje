using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Admin
    {
        public static void Unos(string zapis)
        {
            StreamWriter sw= new StreamWriter("azil.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }
    }
}
