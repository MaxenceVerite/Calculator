using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            // Elements d'entrés - on déclare les variables et le résultat attendu

            int a = 1;
            int b = 2;
            int exp = 3;

            // Calcul

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Add(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            // Elements d'entrés - on déclare les variables et le résultat attendu

            int a = 1;
            int b = 2;
            int exp = -1;

            // Calcul

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Sub(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethodMul()
        {
            // Elements d'entrés - on déclare les variables et le résultat attendu

            int a = 1;
            int b = 2;
            int exp = 2;

            // Calcul

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Mul(a, b);

            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            // Elements d'entrés - on déclare les variables et le résultat attendu

            int a = 4;
            int b = 2;
            int exp = 2;

            // Calcul

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            Assert.AreEqual(exp, actual);
        }


        [TestMethod]
        public void TestMethodDivByZero()
        {
            // Elements d'entrés - on déclare les variables et le résultat attendu

            int a = 4;
            int b = 0;
            int exp = Int32.MinValue;

            // Calcul

            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);

            Assert.AreEqual(exp, actual);
        }

    }
}
