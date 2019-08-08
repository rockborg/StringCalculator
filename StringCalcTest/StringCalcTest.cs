using System;
using Xunit;
using StringCalc;

namespace StringCalcTest
{
    public class StringCalcTest
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 0;
            int result = sc.Add("");
            Assert.Equal(expected,result);
        }

        [Fact]
        public void StringInputReturnsSum()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 8;
            int result = sc.Add("1,2,5");
            Assert.Equal(expected,result);
        }

        [Fact]
        public void StringInputWithNewline()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 6;
            int actual = sc.Add("1\n,2,3");
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void StringInputWithNewline2()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 7;
            int actual = sc.Add("1,\n2,4");
            Assert.Equal(expected,actual);
        }   

        [Fact]
        public void StringInputWithDelimiter()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 8;
            int actual = sc.Add("//;\n1;3;4");
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void StringInputWithDelimiter2()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 6;
            int actual = sc.Add("//$\n1$2$3");
            Assert.Equal(expected,actual);            
        }     

        [Fact]
        public void StringInputWithDelimiter3()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 13;
            int actual = sc.Add("//@\n2@3@8");
            Assert.Equal(expected,actual);            
        }      

        [Fact]
        public void NumberLargerThanAThousand()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 2;
            int actual = sc.Add("2,1001");
            Assert.Equal(expected,actual);            
        }      

        [Fact]
        public void ArbitraryLengthDelimiter()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 6;
            int actual = sc.Add("//***\n1***2***3");
            Assert.Equal(expected,actual);            
        }       

        [Fact]
        public void MultipleDelimitersReturnsSum()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 6;
            int actual = sc.Add("//$,@\n1$2@3");
            Assert.Equal(expected,actual);            
        }          

        [Fact]
        public void MultipleArbitraryLengthDelimiters()
        {
            StringCalculator sc = new StringCalculator();
            int expected = 6;
            int actual = sc.Add("//$$$,@@\n1$$$2@@3");
            Assert.Equal(expected,actual);            
        }                         
    }
}
