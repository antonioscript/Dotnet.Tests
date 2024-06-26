using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests
{
    public class NameTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();

            Assert.Equal("Antônio Rocha", names.MakeFullName("Antônio", "Rocha"));
        }


        //Using Ignore Case
        [Fact]
        public void MakeFullNameTest1()
        {
            var names = new Names();

            Assert.Equal("Antônio Rocha", names.MakeFullName("antônio", "rocha"), ignoreCase:true); 
        }

        //Using Contains
        [Fact]
        public void MakeFullNameTest2()
        {
            var names = new Names();

            Assert.Contains("Antônio", names.MakeFullName("Antônio", "rocha"));
        } 
    }
}
