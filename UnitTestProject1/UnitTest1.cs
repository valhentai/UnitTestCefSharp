﻿using System;
using CefSharp;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Cef.Initialize();
        }
    }
}
