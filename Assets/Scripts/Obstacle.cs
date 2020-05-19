using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //public Rigidbody2D rgBody;
    // public float minSpeed = 1f;
     //public float maxSpeed = 5f;
    public float speed;

    public Transform pos1, pos2;
    public Transform startPos;
    Vector3 nextPos;
    
     void Start()
     {
        // rgBody = GetComponent<Rigidbody2D>();
        nextPos = startPos.position;
        // speed = Random.Range(minSpeed, maxSpeed);
    }

   
    void FixedUpdate()
     {

        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

       // rgBody.MovePosition(transform.position + transform.right * Time.deltaTime);

        //Vector2 forward = new Vector2(transform.right.x, transform.right.y);
       // rgBody.MovePosition(rgBody.position + Vector2.right * Time.fixedDeltaTime);

        /*keep in screen
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -2f, 2f), 
            Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
            */


     }

     
}
