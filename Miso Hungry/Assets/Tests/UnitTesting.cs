using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class NewTestScript
    {
        private GameObject prefab;

        [Test]
        public void LoadPrefabs()
        {
            prefab = Resources.Load<GameObject>("Prefabs/avatar");
        }

        private GameObject newObj;

        [Test]
        public void BuildObj()
        {
            LoadPrefabs();
            newObj = GameObject.Instantiate(prefab);
        }

        private Transform tran;
        [Test]
        public void MoveObj()
        {
            BuildObj();
            tran = newObj.GetComponent<Transform>();
            tran.Translate(Vector3.up);
        }

         [Test]
        public void TestCheckOut()
        {
            CheckPlayerTag("STRING2");
        }
        bool CheckPlayerTag(string STRING)
        {
            if(STRING.Equals("Player"))
            {
                return true;
            }
            return false;
        }
    }
}
