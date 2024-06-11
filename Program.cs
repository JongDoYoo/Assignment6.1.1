namespace Assignment6._1._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var HouseList = new SingleLinkedList();                   // created a link list with no list loaded in it yet

            House house = new House(HouseList);
            HouseList.InsertLast(HouseList, house);

            Console.WriteLine("Please enter the house number about the house you would like to see: ");
            
            int houseNum = Convert.ToInt32(Console.ReadLine());

            HouseList.HouseResults(HouseList, houseNum);


        }

    }
        
    
}
