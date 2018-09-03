namespace DP.AbstractFactory
{
    internal class BmwCar : ICar
    {
        public void StartEngine()
        {
            System.Console.WriteLine("You started a BMW");
        }
    }
}