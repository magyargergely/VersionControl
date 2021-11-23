using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample_v2
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {            
            var accountController = new AccountController();
                        
            var actualResult = accountController.ValidateEmail(email);
                        
            Assert.AreEqual(expectedResult, actualResult);
        }


        [
            Test,
            TestCase("abcd", false),
            TestCase("ABCD1234", false),
            TestCase("abcd1234", false),
            TestCase("a1", false),
            TestCase("Abcd1234", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            bool actualResult;
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");

            if (regex.IsMatch(password) == true)
            {
                actualResult = true;
            }
            else
            {
                actualResult = false;
            }

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
