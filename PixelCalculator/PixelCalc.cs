using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCalculator
{
    public static class PixelCalc
    {
        public static (double, int, double) Calculate(int width, int height, double diagonalInInches)
        {
            double widthSquare = Math.Pow(width, 2);
            double heightSquare = Math.Pow(height, 2);

            double diagonalInPixels = Math.Sqrt((widthSquare + heightSquare));


            double PPI = Math.Round((diagonalInPixels / diagonalInInches), 2);


            double DotPitch = Math.Round((diagonalInInches / diagonalInPixels) * 25.4, 4);


            int DiagonalInPixels = (int)Convert.ToInt64(Math.Round(diagonalInPixels));

            return (PPI, DiagonalInPixels, DotPitch);
        }
    }
}
