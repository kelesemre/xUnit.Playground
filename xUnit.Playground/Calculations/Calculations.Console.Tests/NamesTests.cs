using Xunit;
using System;

namespace Calculations.ConsoleApp.Tests
{
    public class NamesTests
    {
        [Fact]
        public void MakeFullName_TEst()
        {
            var names = new Names();
            var result = names.MakeFullName("emre", "keles");
            Assert.Equal("emre keles", result, ignoreCase: true);
            Assert.Contains("mre", result, StringComparison.InvariantCultureIgnoreCase);
            Assert.StartsWith("emr", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            //names.NickName = "yek";
            //Assert.NotNull(names.NickName);
            Assert.Null(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("emre", "keles");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
