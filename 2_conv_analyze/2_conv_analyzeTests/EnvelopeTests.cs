﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2_conv_analyze;

namespace _2_conv_analyzeTests
{
    [TestClass]
    public class EnvelopeTests
    {
        [TestMethod]
        public void LessOperatorTest_35_64_true()
        {
            Envelope first = new Envelope(3, 5);
            Envelope second = new Envelope(6, 4);
            Assert.IsTrue(first < second);
        }
        [TestMethod]
        public void GreaterOperatorTest_612_105_true()
        {
            Envelope first = new Envelope(6, 12);
            Envelope second = new Envelope(10, 5);
            Assert.IsTrue(first > second);
        }
        [TestMethod]
        public void DiagCmpTest_305_2828_true()
        {
            Envelope first = new Envelope(30, 5);
            Envelope second = new Envelope(28, 28);
            Assert.IsTrue(Envelope.DiagCmp(first, second));
        }
    }
}
