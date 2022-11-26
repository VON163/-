using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Security;
using WpfApp1;

namespace _1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Auth auth = new Auth();
            string expected = "Пароль слишком короткий!";
            string actual = auth.TestPassword("123");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Auth auth = new Auth();
            string expected = "Невозможно использовать пароль т.к. он относиться к часто используемым!";
            string actual = auth.TestPassword("Qwerty123!");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Auth auth = new Auth();
            string expected = "Пароль слишком Длинный!";
            string actual = auth.TestPassword("Adc123!@45678");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать цифры!";
            string actual = auth.TestPassword("AdcAdc!@");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod5()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать симнволы в нижнем регистре!";
            string actual = auth.TestPassword("ADC123!@");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod6()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать символы в верхнем регистре!";
            string actual = auth.TestPassword("adc123!@");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod7()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать спецсимволы!";
            string actual = auth.TestPassword("Adc123Ad");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod8()
        {
            Auth auth = new Auth();
            string expected = "Пароль не должен содержать рядом идущие повторяющиеся символы!";
            string actual = auth.TestPassword("Aaa123!@");
            Assert.AreEqual(expected, actual);

        }


    }
}
