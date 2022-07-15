namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of columns");
            string? sColumnNumber = Console.ReadLine();
            int nColumnNumber = int.Parse(sColumnNumber);
            Console.WriteLine("Please enter distance between columns in meters");
            string sDistance = Console.ReadLine();
            int nDistance = int.Parse(sDistance)*100;
            Console.WriteLine("Please enter the distance between columns in centimeters");
            string? sWidth = Console.ReadLine();
            int nWidth = int.Parse(sWidth);
            int nResult = nDistance*(nColumnNumber-1)+nWidth*(nColumnNumber-2);
            if (nResult < 0)
                {
                nResult = 0;
                }
            Console.WriteLine("Result in centimeters = " + Convert.ToString(nResult));
        }
    }
}