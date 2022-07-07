using LinqChallenge.Domain.Interfaces;

namespace LinqChallenge.Domain.Entities
{
    public class Length : IValidatable
    {        
        // Private Base Length In Centimeters 
        private readonly double _lengthInCentimeters;

        #region Constructors

        public Length(int lengthInCentimeters) { _lengthInCentimeters = lengthInCentimeters; }

        public Length(int feet, int inches) 
        {
            _lengthInCentimeters = ConvertToCentimeters(feet, inches);

            // Helpers for converting Feet & Inches to Centimeters upon initalization.
            double ConvertToCentimeters(int feet, int inches) => 
                CombineFeetAndInches(feet, inches) * _inchesToCentimetersRatio;

            int CombineFeetAndInches(int feet, int inches) =>  (feet * _inchesPerFoot) + inches;
        }

        #endregion

        #region Exposed Properties

        // Exposed Properties
        public int Centimeters => (int)Math.Round(_lengthInCentimeters);

        public int Inches => ConvertCentimetersToInches;

        public (int Feet, int Inches) FeetAndInches => 
            (ParseMaxFeetFromCentimeters, ParseInchesAfterSubtractingFeetFromCentimeters);

        #endregion

        #region Conversions

        // Constants For Conversions
        private const int _inchesPerFoot = 12;

        private const double _inchesToCentimetersRatio = 2.54;

        // Conversions
        private int ParseMaxFeetFromCentimeters => ConvertCentimetersToInches / _inchesPerFoot;

        private int ParseInchesAfterSubtractingFeetFromCentimeters => ConvertCentimetersToInches % _inchesPerFoot;

        private int ConvertCentimetersToInches => (int)Math.Round(_lengthInCentimeters / _inchesToCentimetersRatio);

        #endregion

        #region Operator Overloads

        public static Length operator +(Length a, Length b) => new(a.Centimeters + b.Centimeters);

        public static Length operator -(Length a, Length b) => new(a.Centimeters - b.Centimeters);

        public static Length operator /(Length a, Length b) => new(a.Centimeters / b.Centimeters);

        public static Length operator *(Length a, Length b) => new(a.Centimeters * b.Centimeters);

        public static bool operator >(Length a, Length b) => a.Centimeters > b.Centimeters;

        public static bool operator <(Length a, Length b) => a.Centimeters < b.Centimeters;

        #endregion

        #region Validation

        public string? ValidationMessage { get ; set ; }

        public bool IsValid()
        {
            ValidationMessage = "Invalid Height - Height must be greater than 0.";
            return Centimeters > 0;
        }

        #endregion
    }
}