using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanMovement : MonoBehaviour
{

    private float moveHorizontal = 1;
    private float moveVertical = 1;
    public float speed;
    private bool isKeyPressed = false;
    private bool hasCollided = false;

    void FixedUpdate()
    {
        if (Input.anyKeyDown)
        {
            isKeyPressed = !isKeyPressed;
            
        }

        if (isKeyPressed)
        {
           transform.Translate(moveHorizontal * 0.2f * speed, moveVertical * 0.045f * speed, 0);
        }

        if (hasCollided)
        {
            moveHorizontal = moveHorizontal * -1;
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Wall") == true)
        {
            hasCollided = !hasCollided;
        }

    }

}
