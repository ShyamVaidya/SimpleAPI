using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController valuesController = new ValuesController();

        [Fact]
        public void GetReturnValue()
        {
            var returnValue = valuesController.Get(1);

            Assert.Equal("Something else", returnValue.Value);
        }
    }
}
