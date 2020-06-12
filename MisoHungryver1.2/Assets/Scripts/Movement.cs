using UnityEngine;

//for player controller : movement
public class Movement
{
    public float moveSpeed;

    public Movement(float speed)
    {
        moveSpeed = speed;

    }
    public Vector2 CalcMovement(float h, float v, float deltaTime)
    {
       //right and left direction
        var horizontal_movement = h * moveSpeed * deltaTime;
        //up and down direction
        var vertical_movement = v * moveSpeed * deltaTime;

        return new Vector2(horizontal_movement, vertical_movement);
    }
    


}
