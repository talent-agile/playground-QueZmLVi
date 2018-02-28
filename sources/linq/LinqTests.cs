using Linq.Domain;
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
    }
}
