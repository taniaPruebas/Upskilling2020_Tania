using NUnit.Framework;
using WebApp;

namespace Cat.Dog.NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_Only_positive_numbers()
        {
            int result;
            result = WebApp.Program.Cat_Dog_to_Evaluate(7,8);
            Assert.IsTrue(result>0,"ONLY POSITIVE Bigger that Zero");
            Assert.IsFalse(result<0,"ONLY POSITIVE Not smaller than Zero");

        }
        [Test]
        public void Test2_Only_negatives_numbers()
        {
            
            int result;
            result = WebApp.Program.Cat_Dog_to_Evaluate(7,-8);
            Assert.IsTrue(result<0, "ONLY NEGATIVES Smaller than Zero");
            Assert.IsFalse(result>0,"ONLY NEGATIVES No bigger than Zero");

        }
    }
}