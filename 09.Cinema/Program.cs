namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int totalSeats = seats * rows;
            double totalPrice = 0;

           if (type == "Premiere")
            {
                totalPrice = totalSeats * 12.00;
            }
           else if (type == "Normal")
            {
                totalPrice = totalSeats * 7.50;
            }
           else if (type == "Discount")
            {
                totalPrice = totalSeats * 5.00;
            }
            Console.WriteLine($"{totalPrice:F2}");


            //По - подробен вариант на решение:
            //string type = Console.ReadLine();
            //int rows = int.Parse(Console.ReadLine());
            //int seats = int.Parse(Console.ReadLine());
            //double price = 0;
            //int totalSeats = 0;
            //double totalPrice = 0;

            //if (type == "Premiere")
            //{
            //    price = 12.00;
            //    totalSeats = seats * rows;
            //    totalPrice = totalSeats * price;
            //    Console.WriteLine($"{totalPrice:F2}");
            //}
            //else if (type == "Normal")
            //{
            //    price = 7.50;
            //    totalSeats = seats * rows;
            //    totalPrice = totalSeats * price;
            //    Console.WriteLine($"{totalPrice:F2}");
            //}
            //else if (type == "Discount")
            //{
            //    price = 5.00;
            //    totalSeats = seats * rows;
            //    totalPrice = totalSeats * price;
            //    Console.WriteLine($"{totalPrice:F2}");
            //}
        }
    }
}