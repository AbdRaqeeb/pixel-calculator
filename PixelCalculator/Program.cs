namespace PixelCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool isContinuing = true;

            while (isContinuing)
            {
                var message = "1. Enter Screen dimensions\r\n2. Exit";

                int value = GetIntValue(message);

                while (value < 1 || value > 3)
                {
                    value = GetIntValue(message);
                }

                if (value == 1)
                {
                    int width;
                    int height;
                    int diagonal;

                    width = GetIntValue("Width: ");

                    height = GetIntValue("Height: ");

                    diagonal = GetIntValue("Diagonal: ");

                    var (PPI, DiagonalInPixels, DotPitch) = PixelCalc.Calculate(width, height, diagonal);

                    Console.WriteLine($"PPI: {PPI}\nDiagonal (in pixels): {DiagonalInPixels}\nDot pitch: {DotPitch}\n");
                } else
                {
                    isContinuing = false;
                }
            }
        }

        static int GetIntValue(string message)
        {
            int value;
            string line = "";
            bool isValidInt = false;

            while (!isValidInt)
            {
                Console.WriteLine(message);
                line = Console.ReadLine();
                if (Int32.TryParse(line, out value) && value > 0)
                {
                    isValidInt = true;
                }
            }

            return int.Parse(line);
        }
    }
}
