using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    //class for unit testing for all sprites that player collides with
    public class PlayerCollisionTest
    {
        [Test]
        public void TestMisoSprite()
        {
            var go = new GameObject("Miso_sprite");
            Assert.AreEqual("Miso_sprite", go.name);
        }
        [Test]
        public void TestLeekSprite()
        {
            var go = new GameObject("Leek");
            Assert.AreEqual("Leek", go.name);
        }

        [Test]
        public void TestSpoonSprite()
        {
            var go = new GameObject("Spoon");
            Assert.AreEqual("Spoon", go.name);
        }
        [Test]
        public void TestWasabiSprite()
        {
            var go = new GameObject("wasabi_obstacle");
            Assert.AreEqual("wasabi_obstacle", go.name);
        }

    }
}
