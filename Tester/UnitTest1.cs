using System;
using System.Diagnostics;
using Xunit;

namespace Tester
{
    public class UnitTest1
    {
        [Fact]
        public void AlwaysFail()
        {
            //Assert.True(false);
           // Assert.False(true);

        }
        [Fact]
        public void Testa1()
        {

            Assert.Equal(5, 2+3);

        }
        [Fact]
        public void Testa2()
        {
            Assert.True("Jag har fyllt" + 29 == "Jag har fyllt 29");

        }
        [Fact]
        public void Test3r()
        {

            int bigNumber = 2147483647;
            int biggerNumber = bigNumber + 1;
            Assert.True(biggerNumber > bigNumber);

        }
        [Fact]
        public void Testa4()
        {
            int age = 28;

            if (age > 18)
            {
                string purchasedDrink;

                if(age>18)
                {
                    purchasedDrink = "Beer";

                }
                else
                {
                    purchasedDrink = "Coca-cola";
                }
                
                Assert.Equal("Beer", purchasedDrink);
            }

        }
    }
}
