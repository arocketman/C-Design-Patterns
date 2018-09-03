namespace DP.AbstractFactory
{
    internal class AudiCar : ICar
    {
        public void StartEngine()
        {
            System.Console.WriteLine("You started a AUDI");
        }
    }
}