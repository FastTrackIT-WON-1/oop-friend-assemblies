using FriendAssemblies.Lib;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace FriendAssemblies.Tests
{
    public class HelpersTests
    {
        [Fact]
        public void ConvertFromString_HappyFlow()
        {
            int result = Helpers.ConvertFromString("123");
            Assert.Equal(123, result);
        }
    }
}
