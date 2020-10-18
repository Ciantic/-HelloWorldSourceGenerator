using System;
using Xunit;
using MyGeneratedNamespace;

namespace MyGenerator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var f = new MyGeneratedClass();
            Assert.Equal(f.HelloWorld(), "Hello World");
        }
    }
}
