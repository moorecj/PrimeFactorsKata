using NUnit.Framework;
using PrimeFactorsKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsTests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        private PrimeFactors primefactors;
        private List<Int32> expected;

        [SetUp]
        public void Setup()
        {
            primefactors  = new PrimeFactors();
            expected = new List<Int32>();
        }

        [Test]
        public void Generate_ShouldReturnAnListOfInts()
        {
            Assert.That(primefactors.Generate(0), Is.InstanceOf<List<Int32>>());
        }

        [Test]
        public void GenerateOfOne_ShouldReturnAnEmptyList()
        {
            Assert.That(primefactors.Generate(1).Count, Is.EqualTo(0));
        }

        [Test]
        public void GenerateOfTwo_ShouldReturnTwo()
        {
            expected.Add(2);

            Assert.That(primefactors.Generate(2), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfThree_ShouldReturnThree()
        {
            expected.Add(3);

            Assert.That(primefactors.Generate(3), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfFour_ShouldReturnAListof2and2()
        {
            expected.Add(2);
            expected.Add(2);

            Assert.That(primefactors.Generate(4), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfFive_ShouldReturnAListOf5()
        {
            expected.Add(5);

            Assert.That(primefactors.Generate(5), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfSix_ShouldReturnAListOf2And3()
        {
            expected.Add(2);
            expected.Add(3);

            Assert.That(primefactors.Generate(6), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfSeven_ShouldReturnAListOfSeven()
        {
            expected.Add(7);

            Assert.That(primefactors.Generate(7), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfEight_ShouldReturnAListOf2And2And2()
        {
            expected.Add(2);
            expected.Add(2);
            expected.Add(2);

            Assert.That(primefactors.Generate(8), Is.EqualTo(expected));
        }

        [Test]
        public void GenerateOfNine_ShouldReturnAListOf3And3()
        {
            expected.Add(3);
            expected.Add(3);

            Assert.That(primefactors.Generate(9), Is.EqualTo(expected));
        }
    }
}
