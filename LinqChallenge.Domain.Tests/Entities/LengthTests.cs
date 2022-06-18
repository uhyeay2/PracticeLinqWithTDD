namespace LinqChallenge.Domain.Tests.Entities
{
    [TestFixture]
    public class LengthTests
    {
        #region TestCase Data

        private static readonly VerifiedLength[] VerifiedLengths = {
            new (99, 39, (3, 3)), new (25, 10, (0, 10)), new (254, 100, (8, 4)), new (300, 118, (9, 10))
        };

        public class VerifiedLength
        {
            public int Centimeters, Inches; 
            
            public (int Feet, int Inches) FeetAndInches;

            public VerifiedLength(int centimeters, int inches, (int, int) feetAndInches)
            {
                Centimeters = centimeters;
                Inches = inches;
                FeetAndInches = feetAndInches;
            }
        }

        #endregion

        [TestCaseSource(nameof(VerifiedLengths))]
        public void Length_CreatedWithCentimeters_Exposes_CorrectCentimeters(VerifiedLength expected)
        {
            var length = new Length(expected.Centimeters);

            Assert.That(length.Centimeters, Is.EqualTo(expected.Centimeters));
        }

        [TestCaseSource(nameof(VerifiedLengths))]
        public void Length_CreatedWithCentimeters_Exposes_CorrectInches(VerifiedLength expected)
        {
            var length = new Length(expected.Centimeters);

            Assert.That(length.Inches, Is.EqualTo(expected.Inches));
        }

        [TestCaseSource(nameof(VerifiedLengths))]
        public void Length_CreatedWithCentimeters_Exposes_CorrectFeetAndInches(VerifiedLength expected)
        {
            var length = new Length(expected.Centimeters);

            Assert.That(length.FeetAndInches, Is.EqualTo(expected.FeetAndInches));
        }

        [TestCaseSource(nameof(VerifiedLengths))]
        public void Length_CreatedWithFeetAndInches_Exposes_CorrectCentimeters(VerifiedLength expected)
        {
            var length = new Length(expected.FeetAndInches.Feet, expected.FeetAndInches.Inches);

            Assert.That(length.Centimeters, Is.EqualTo(expected.Centimeters));
        }

        [TestCaseSource(nameof(VerifiedLengths))]
        public void Length_CreatedWithFeetAndInches_Exposes_CorrectInches(VerifiedLength expected)
        {
            var length = new Length(expected.FeetAndInches.Feet, expected.FeetAndInches.Inches);

            Assert.That(length.Inches, Is.EqualTo(expected.Inches));
        }

        [TestCaseSource(nameof(VerifiedLengths))]
        public void Length_CreatedWithFeetAndInches_Exposes_CorrectFeetAndInches(VerifiedLength expected)
        {
            var length = new Length(expected.FeetAndInches.Feet, expected.FeetAndInches.Inches);

            Assert.That(length.FeetAndInches, Is.EqualTo(expected.FeetAndInches));
        }
    }
}