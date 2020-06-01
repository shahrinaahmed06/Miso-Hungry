using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed ;
    public Movement Movement;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Movement = new Movement(moveSpeed);
    }
    void FixedUpdate()
    {
        rb.velocity = Movement.CalcMovement(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);
    }

    //for player collision with miso
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Miso"))
        {
            Destroy(other.gameObject); //miso soup disappears 
                                       // score += 10;
                                       // Debug.Log("Score: " + score);
        }
    }

}

