using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class charactergenerator : MonoBehaviour
{
    public List<GameObject> CharacterPrefabList = new List<GameObject>();

    void Start()
    {
        Instantiate(CharacterPrefabList[(int)character.character1 - 1], transform.position, Quaternion.identity);
        print((int)character.character1 - 1);
    }



}
