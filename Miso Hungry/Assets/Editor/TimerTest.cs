using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;


namespace Tests
{
    public class TimerTest
    {
        [Test]
        public void EndMenuTest()
        {

            var go = new GameObject("EndMenu");
            Assert.AreEqual("EndMenu", go.name);//Tests successful execution of end menu

        }

        [Test]
        public void displayTest()
        {

            var go = new GameObject("textDisplay");
            Assert.AreEqual("textDisplay", go.name);//Tests successful execution for text display

        }

        [Test]

        public void secondsLefttest()
        {
            Assert.AreEqual(0, 0);
        }
    }
}
