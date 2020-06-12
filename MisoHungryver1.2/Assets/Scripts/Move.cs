using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform Target1;
    public Transform Target2;
    private Vector3 _pos1;
    private Vector3 _pos2;

    public Transform StartPos;
    public float Offset = 0.05f;
    public float Sp = 5f;

    private Transform _transform;


    void Start()
    {
        _transform = GetComponent<Transform>();
        _pos1 = Target1.position;
        _pos2 = Target2.position;

        StartCoroutine(Moving(StartPos.position));
    }


    IEnumerator Moving(Vector3 pos)
    {
        Vector3 dir = (pos - _transform.position).normalized;

        while (true)
        {
            if (Vector3.Distance(pos, _transform.position) <= Offset)
            {
                break;
            }

            //   _transform.position = Vector3.MoveTowards(_transform.position, pos, Sp * Time.deltaTime);

            _transform.Translate(dir * Sp * Time.deltaTime);
            yield return null;
        }

        MoveNext();
    }

    private void MoveNext()
    {
        if (Vector3.Distance(_pos1, _transform.position) <= Offset)
        {
            StartCoroutine(Moving(_pos2));
        }
        else if (Vector3.Distance(_pos2, _transform.position) <= Offset)
        {
            StartCoroutine(Moving(_pos1));
        }
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }
}