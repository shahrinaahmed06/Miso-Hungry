
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //declare variables
    public float moveSpeed = 150.0f;
    public Movement Movement;
    private Rigidbody2D rb;
    public GameObject Misosound;
    public GameObject Obstaclesound;
    bool faceRight = true;
    public float Hmovement=50f, Vmovement=50f;
    public GameObject EndMenu;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Movement = new Movement(moveSpeed);
    }
    void FixedUpdate()
    {
        //for player movement 
        Hmovement = Input.GetAxisRaw("Horizontal");
        Vmovement = Input.GetAxisRaw("Vertical");
        //flips avatar sprite for horizontal movement
        flip(Hmovement);
        //calls method from movement class to implmement horizontal and vertical movement
        rb.velocity = Movement.CalcMovement(Hmovement, Vmovement, Time.deltaTime);
        if (Score.score < 0)
        {
            EndMenu.SetActive(true);
        }

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
            Score.score += 10;
            //sprite disappear as it is collected
            Destroy(other.gameObject);
        }

        //leek sprite collision
        else if (other.gameObject.name.Equals("Leek"))
        {
            Instantiate(Misosound, transform.position, Quaternion.identity);
            Score.score += 15;
            Destroy(other.gameObject);

        }
        //leek sprite collision
        else if (other.gameObject.name.Equals("Spoon"))
        {
            Instantiate(Misosound, transform.position, Quaternion.identity);
            Score.score += 20;
            Destroy(other.gameObject);

        }
        //obstacle collision
        else if (other.gameObject.name.Equals("wasabi_obstacle"))
        {
            Instantiate(Obstaclesound, transform.position, Quaternion.identity);
            Score.score -= 20;

        }
       
    }

    public void ReStart()//function to resatrt the level
    {
        EndMenu.SetActive(false);//deactivate the end level menu
        Time.timeScale = 1;/// start scene 

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//return the level played level.

    }

    //method to flip character facing the direction it is moving in horizontal axis
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