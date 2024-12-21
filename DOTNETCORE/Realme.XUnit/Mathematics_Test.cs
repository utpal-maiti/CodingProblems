using Common.Lib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realme.XUnit
{
    public class Mathematics_Test
    {
        [Fact]
        public void EvenNumberTest()
        {
            //Arrange
            var num = 6;
            //Act
            bool result = Mathematics.IsEvenNumber(num);
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(5)]
        public void OddNumberTest(int num)
        {
            //Act
            bool result = Mathematics.IsOddNumber(num);
            //Assert
            Assert.True(result);
        }
    }
}
