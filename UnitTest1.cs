using System.Security.Cryptography.X509Certificates;
using UserRegistrationRegex;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1foruserfirstname()
        {
            //Rule1: Arrange test case
            UserDetails userobject=new UserDetails();

            string username = "Monika";
            bool expected = true;
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            //Rule 2: Act
           bool result= UserDetails.Iteration(username,regexCondition);
            //Rule3: Assert
            Assert.AreEqual(expected,result);

        }
        [TestMethod]
        public void TestMethod1foruserpassword()
        {
            //Rule1: Arrange test case
            UserDetails userobject = new UserDetails();
            //UpperCase1+AndNumeric1
            string userpassword = "Monikaa1";
            bool expected = true;
            string regexCondition = "^[A-Za-z0-9]{8,}$";
            //Rule 2: Act
            bool result = UserDetails.Iteration(userpassword, regexCondition);
            //Rule3: Assert
            Assert.AreEqual(expected, result);

        }
    }
}