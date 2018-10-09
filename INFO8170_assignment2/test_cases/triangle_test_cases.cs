using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFO8170_assignment2;
using NUnit.Framework;


namespace test_cases
{
    [TestFixture]
    public class triangle_test_cases
    {
        [Test]
        //test1
        public void Analyze_input12and12and12_expectedResultEqualsEquilateral()
        {
            //Arrange
            int side1 = 12;
            int side2 = 12;
            int side3 = 12;
            string answer = "equilateral is a type of triangle";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }

        [Test]
        //test2
        public void Analyze_input22and23and25_expectedResultEqualsScalene()
        {
            //Arrange
            int side1 = 22;
            int side2 = 23;
            int side3 = 25;
            string answer = "scalene is a type of triangle";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }
        [Test]
        //test3
        public void Analyze_input22and22and25_expectedResultEqualsIsosceles()
        {
            //Arrange
            int side1 = 22;
            int side2 = 22;
            int side3 = 25;
            string answer = "isosceles is a type of triangle";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }

        [Test]
        //test4
        public void Analyze_inputnegative22andnegative22and25_expectedResultEqualsThrowsError()
        {
            //Arrange
            int side1 = -22;
            int side2 = -22;
            int side3 = 25;
            string answer = "invalid inputs";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }
        [Test]
        //test5
        public void Analyze_inputnegative22andnegative22andnegative25_expectedResultEqualsThrowsError()
        {
            //Arrange
            int side1 = -22;
            int side2 = -22;
            int side3 = -25;
            string answer = "invalid inputs";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }
        [Test]
        //test6
        public void Analyze_inputnegative22and23and25_expectedResultEqualsThrowsError()
        {
            //Arrange
            int side1 = -22;
            int side2 = 23;
            int side3 = 25;
            string answer = "invalid inputs";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }
        [Test]
        //test7
        public void Analyze_input2and3and5_expectedResultThrowsException()
        {
            //Arrange
            int side1 = 2;
            int side2 = 3;
            int side3 = 5;
            string answer = "invalid inputs";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }
        [Test]
        //test 8
        public void Analyze_input12and12and0_expectedResultThrowsException()
        {
            //Arrange
            int side1 = 12;
            int side2 = 12;
            int side3 = 0;
            string answer = "invalid inputs";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(result, answer);
        }









    }
}
