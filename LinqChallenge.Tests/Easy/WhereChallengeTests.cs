using LinqChallenge.Easy;

namespace LinqChallenge.Tests.Easy
{
    [TestFixture]
    public class WhereChallengeTests
    {
        /*  Getting Started Instructions
            
            TODO: Read Instructions! - You can delete this line after reading 
                                        - You can see TODO's from ( View -> Task List )         


            Below I have created the start of a first test for you. You still need to make a few changes,
                    such as renaming the test method's name, or making sure that your result is correct.


            After your first test (Which should only be asserting one requirement!) you can move on to the next requirement.
                    - Once you have completed all requirements for a method, you can move on and try another!


            If you'd like to see how I created the tests, feel free to take a peek at one of the other branches.

            Introduction Video: https://drive.google.com/file/d/17m934DFY45EtUr4H8YCJbtORUF5rPDYq/view?usp=sharing

        */

        [Test]
        public void GetPeopleOlderThanEighteen_MakeYourFirstTest()
        {
            // I gave you a head start. You still need to finish the test though.

            // Arrange 
            var challenge = new WhereChallenge();

            // Act
            var result = challenge.GetPeopleOlderThanEighteen(null!);

            // Assert
            throw new Exception("You need to Assert your result is correct! && Remove this Exception (: ");
        }

        /*      
                Hint: You can view your next requirements by going to LinqChallenge.Easy.WhereChallenge.cs
                      - Find the GetPeopleOlderThanEighteen method, and view the comments above it.
                      - Hold Ctrl Key + Left Click WhereChallenge(); to have VS take you to that class.
        */
    }
}