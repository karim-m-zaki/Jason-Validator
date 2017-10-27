using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonValidator.WebApi.Services;

namespace JsonValidator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidTest1()
        {
            ValidatorService s = new ValidatorService();
            var result=s.JsonValidator(Config.VALID_TEST1);
            //Assertion
            Assert.AreEqual(Tuple.Create(true, "Json is Valid"), result);
        }
        [TestMethod]
        public void ValidTest2()
        {
            ValidatorService s = new ValidatorService();
            var result = s.JsonValidator(Config.VALID_TEST2);
            //Assertion
            Assert.AreEqual(Tuple.Create(true, "Json is Valid"), result);
        }
        [TestMethod]
        public void ValidTest3()
        {
            ValidatorService s = new ValidatorService();
            var result = s.JsonValidator(Config.VALID_TEST3);
            //Assertion
            Assert.AreEqual(Tuple.Create(true, "Json is Valid"), result);
        }
        [TestMethod]
        public void InValidTest1()
        {
            ValidatorService s = new ValidatorService();
            var result = s.JsonValidator(Config.INVALID_TEST1);
            
            Assert.AreEqual(Tuple.Create(false, "} has no opening"), result);
        }
        [TestMethod]
        public void InValidTest2()
        {
            ValidatorService s = new ValidatorService();
            var result = s.JsonValidator(Config.INVALID_TEST2);
            //
            Assert.AreEqual(Tuple.Create(false, "} is a closing without a proper opening"), result);
        }
        [TestMethod]
        public void InValidTest3()
        {
            ValidatorService s = new ValidatorService();
            var result = s.JsonValidator(Config.INVALID_TEST3);
            //
            Assert.AreEqual(Tuple.Create(false, "] is a closing without a proper opening"), result);
        }
        [TestMethod]
        public void InValidTest4()
        {
            ValidatorService s = new ValidatorService();
            var result = s.JsonValidator(Config.INVALID_TEST4);
            //
            Assert.AreEqual(Tuple.Create(false, "} has no opening"), result);
        }
    }
}
