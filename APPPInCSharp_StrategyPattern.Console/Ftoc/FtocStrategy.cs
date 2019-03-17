using System.IO;

namespace APPPInCSharp_StrategyPattern.Console.Ftoc
{
    public class FtocStrategy : Application
    {
        private TextReader input;
        private TextWriter output;
        private bool isDone = false;

        public void Init()
        {
            input = System.Console.In;
            output = System.Console.Out;
        }

        public void Idle()
        {
            string fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
            {
                isDone = true;
            }
            else
            {
                double fahr = double.Parse(fahrString);
                double celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine($"F={fahr}, C={celcius}");
            }
        }

        public void Cleanup()
        {
            output.WriteLine("ftoc exit");
        }

        public bool Done() => isDone;
    }
}