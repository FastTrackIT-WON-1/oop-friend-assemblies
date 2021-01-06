using FriendAssemblies.Lib;
using Xunit;

namespace FriendAssemblies.Tests
{
    public class ArrayHelperTests
    {
        [Fact]
        public void ParseList_HappyFlow()
        {
            int[] result = ArrayHelper.ParseList("1, 2, 3");

            Assert.Equal(new[] { 1, 2, 3 }, result);
        }
    }
}
