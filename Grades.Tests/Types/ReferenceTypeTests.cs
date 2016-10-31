using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{

    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);

        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferanceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Pompi";
            string name2 = "pompi";
            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);

                

        }
        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Pompi's Gradebook";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
