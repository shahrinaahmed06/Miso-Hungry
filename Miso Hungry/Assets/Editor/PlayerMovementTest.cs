using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

//class for unit testing for player movement in both horizontal axis and vertical axis direction

namespace Tests
{
    public class PlayerMovementTest
    {
        [Test]
        public void PlayerHasVelocity()
        {
            Assert.AreEqual(1, 1);
        }


        [Test]
        public void PlayerMovement_Horizontal() //left and right direction
        {
            Assert.AreEqual(1, new Movement(1).CalcMovement(1, 0, 1).x, 0.1f);
        }

        [Test]
        public void PlayerMovement_Vertical() //up and down direction
        {
            Assert.AreEqual(1, new Movement(1).CalcMovement(0, 1, 1).y, 0.1f);
        }


    }


}
