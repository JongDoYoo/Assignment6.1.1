using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    public class House
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string HouseType { get; set; }

        internal House (SingleLinkedList HouseList )
        {
            
            Console.WriteLine("Please enter house number: ");
            HouseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter street Name: ");
            StreetName = (Console.ReadLine());
            Console.WriteLine("Please enter house type: ");
            HouseType = (Console.ReadLine());

            //Add to linked list          
        }
    }

}
