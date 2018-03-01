﻿using Linq.Domain;
using Linq.Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Linq
{
    [TestClass]
    public class LinqTests
    {
        private Data _data;

        [TestInitialize]
        public void Initialize()
        {
            _data = DataGenerator.GenerateData();
        }

        [TestMethod]
        public void CheckTotalOrderSum()
        {
            var actual = TotalOrderSum.CalculateTotalOrderSum(_data);
            Check.That(actual).IsEqualTo(349823300M);
        }

        [TestMethod]
        public void CheckNumberOfOrdersInApril2016()
        {
            var actual = NumberOfOrdersInApril2016.CalculateNumberOfOrdersInApril2016(_data);
            Check.That(actual).IsEqualTo(4146);
        }

        [TestMethod]
        public void CheckMonthWithHighestIncome()
        {
            var actual = MonthWithHighestIncome.GetMonthWithHighestIncome(_data);
            Check.That(actual).IsEqualTo(new Date(2015, 7));
        }
    }
}
