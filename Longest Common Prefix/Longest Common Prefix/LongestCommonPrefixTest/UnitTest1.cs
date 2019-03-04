using System;
using Xunit;
using LongestCommonPrefix;

namespace LongestCommonPrefixTest
{
    public class UnitTest1
    {
        [Fact] 
        public void Test1()
        {
            var controller = new CommonPrefix();
            string[] data = new string[]
            {
                "flower",
                "flow",
                "flight",
            }; 
            var result = controller.checkPrefix(data);
            Assert.Equal("fl", result);
        }

        [Fact]
        public void Test2()
        {
            var controller = new CommonPrefix();
            string[] data = new string[]
            {
                "cat",
                "birth",
                "ant",
            }; 
            var result = controller.checkPrefix(data);
            Assert.Equal("", result);
        }
    }
}
