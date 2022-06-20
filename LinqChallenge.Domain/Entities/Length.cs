namespace LinqChallenge.Domain.Entities
{
    public class Length
    {
        // Constructors
        public Length(int lengthInCentimeters) { _lengthInCentimeters = lengthInCentimeters; }

        public Length(int feet, int inches) { _lengthInCentimeters = ConvertToCentimeters(feet, inches); }          


        // Exposed Properties
        public int Centimeters => (int)Math.Round(_lengthInCentimeters);

        public int Inches => ConvertCentimetersToInches;

        public (int Feet, int Inches) FeetAndInches => (ParseMaxFeetFromCentimeters, ParseLeftoverInchesAfterSubtractingFeetFromCentimeters);
        

        // Private Base Length In Centimeters 
        private readonly double _lengthInCentimeters;


        // Constants For Conversions
        private const int _inchesPerFoot = 12;

        private const double _inchesToCentimetersRatio = 2.54;


        // Conversions
        private int ParseLeftoverInchesAfterSubtractingFeetFromCentimeters => ConvertCentimetersToInches % _inchesPerFoot;

        private int ParseMaxFeetFromCentimeters => ConvertCentimetersToInches / _inchesPerFoot;

        private int ConvertCentimetersToInches => (int)Math.Round(_lengthInCentimeters / _inchesToCentimetersRatio);

        private static int CombineFeetAndInches(int feet, int inches) => (feet * _inchesPerFoot) + inches;

        private static double ConvertToCentimeters(int feet, int inches) => CombineFeetAndInches(feet, inches) * _inchesToCentimetersRatio;
    }
}