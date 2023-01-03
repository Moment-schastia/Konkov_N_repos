
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace CSharpException
{
    internal class Triangle
    {
        private int _firstSide;
        private int _secondSide;
        private int _thirdSide;
        
        public Triangle() { }

        public int FirstSide
        {
            get => _firstSide;
            set
            {
                if (value <= 0)
                    throw new UnsuitableZeroValue("The side cannot be zero");

                _firstSide = value;
            }
        }
        public int SecondSide 
        { 
            get => _secondSide;
            set
            {
                if (value <= 0)
                    throw new UnsuitableZeroValue("The side cannot be zero");

                _secondSide = value;
            }
        }      

        public int ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (value <= 0)
                    throw new UnsuitableZeroValue("The side cannot be zero");

                _thirdSide = value;
            }
        }

        public int SideCheck(int sideOne, int sideTwo, int sideThree)
        {
            bool oneBiger = sideOne > sideTwo + sideThree;
            bool twoBiger = sideTwo > sideOne + sideTwo;
            bool threeBiger = sideThree > sideTwo + sideOne;

            if (oneBiger || twoBiger || threeBiger)
            {
                throw new OversizedTriangeSideException("One of sides is longer then the sum of the other two!");
            }
            else
            {
                return sideOne;
                return sideTwo;
                return sideThree;
            }
        }

        public int ZeroCheck(int justSide)
        {
            while (justSide == 0)
            {
                justSide = int.Parse(Console.ReadLine());

                IsZero(justSide);
            }
            
            return justSide;
        }

        public bool IsZero(int justSide)
        {
            if (justSide == 0 || justSide < 0)
            {
                throw new UnsuitableZeroValue("The side cannot be zero");
            }
            else
            {
                return true;
            }           
        }
    }
}
