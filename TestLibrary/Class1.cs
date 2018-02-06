using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestLibrary
{
    public class Class1
    {
        [Fact]
        public void TestMethod1()
        {
            Cef.Initialize();
        }
    }
}
