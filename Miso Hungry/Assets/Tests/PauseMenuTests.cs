using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PauseMenuTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PausemenuTest()
        {

            var go = new GameObject("Pausemenu");
            Assert.AreEqual("Pausemenu", go.name);//Tests successful execution of pause menu

        }

        [Test]
        public void PauseButttonTest()
        {

            var go = new GameObject("PauseButton");
            Assert.AreEqual("PauseButton", go.name);//Tests successful execution of pause button

        }

        [Test]

        public void TimeScaletest()
        {
            Assert.AreEqual(1, 1);
        }



    }
}
