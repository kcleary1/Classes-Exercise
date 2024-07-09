namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            firstCar.Make = "Toyota";
            firstCar.Model = "Corolla";
            firstCar.Year = "1994";

            Console.WriteLine($"My first car was a {firstCar.Year} {firstCar.Make} {firstCar.Model}.");
            
            
            
        }

       
    }




}
