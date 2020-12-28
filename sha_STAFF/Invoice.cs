using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sha_STAFF
{
   static class Invoice
    {
        static int id;
        static string name;
        static int price;
        static string datetime;

       public static void addprice(int x)
        {
            price += x;
        }
        public static void cancelitem(int x)
        {
            price -= x;
        }
        public static int check()
        {
            return price;
        }




    }
}
