
using System.Diagnostics;

namespace CSharpException
{
    internal class Triangle
    {
        private int _firstSide;
        private int _secondSide;
        private int _thirdSide;
        
        public Triangle() { }

        public Triangle(int firstSide, int secondSide, int thirdside)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdside;
        }

        public int FirstSide
        {
            get => _firstSide;
            set
            {
                if (value == 0)
                {
                }
                else
                {
                    _firstSide = value;
                }
            }
        }
        public int SecondSide 
        { 
            get => _secondSide;
            set
            {
                if (value > FirstSide + ThirdSide)
                {
                    throw new OversizedTriangeSideException("Second side is longer then the sum of the other two!", value.ToString());
                }
                else
                {
                    _secondSide = value;
                }                    
            }
        }
        public int ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (value > FirstSide + ThirdSide)
                {
                    throw new OversizedTriangeSideException("Third side is longer then the sum of the other two!", value.ToString());
                }
                else
                {
                    _thirdSide = value;
                }
            }
        }
    }
}
