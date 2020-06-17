using UnityEngine;

//This class implements actions and attributes of the player sprite.
//-player movement
//-collision with other sprites

public class PlayerController : MonoBehaviour
{
    //declare variables
    public float moveSpeed=150.0f ;
    public Movement movement;
    private Rigidbody2D rb;
    public GameObject Misosound;
    public GameObject Obstaclesound;
    bool faceRight = true;
    public float Hmovement, Vmovement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = new Movement(moveSpeed);
    }
    void FixedUpdate()
    {
        //for player movement 
        Hmovement = Input.GetAxisRaw("Horizontal");
        Vmovement = Input.GetAxisRaw("Vertical");
        //flips avatar sprite for horizontal movement
        flip(Hmovement);
        //calls method from movement class to implement horizontal and vertical movement
        rb.velocity = movement.CalcMovement(Hmovement, Vmovement, Time.deltaTime);
 
    }

    //player collision with other sprites
     private void OnTriggerEnter2D(Collider2D other)
    {
        //collectible sprites: miso, leek, spoon
        //miso sprite collision
        if (other.gameObject.name.Equals("Miso_sprite"))
        {
            //produce sound effect to warn player collision occurred
           Instantiate(Misosound, transform.position, Quaternion.identity);
            //sprite disappear as it is collected
            Destroy(other.gameObject); 
        }

        //leek sprite collision
        else if (other.gameObject.name.Equals("Leek"))
        {
            Instantiate(Misosound, transform.position, Quaternion.identity);
            Destroy(other.gameObject);

        }
        //leek sprite collision
        else if (other.gameObject.name.Equals("Spoon"))
        {
            Instantiate(Misosound, transform.position, Quaternion.identity);
            Destroy(other.gameObject);

        }
        //obstacle collision
        else if (other.gameObject.name.Equals("wasabi_obstacle"))
        {
            Instantiate(Obstaclesound, transform.position, Quaternion.identity);

        }
    }

    //method to flip character in facing the direction it is moving in horizontal axis
    public void flip(float move)
    {
        
        if (move > 0 && !faceRight || move < 0 && faceRight)
        {
            faceRight = !faceRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            //transform.Rotate(0f, 180f, 0f);
        }
    }

}

