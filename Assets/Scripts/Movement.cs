using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float minX, maxX, minY, maxY;
}

public class Movement : MonoBehaviour {

    // Public variables
    public float speed;
    public float minX, maxX, minY, maxY;

    // Private Variables
    private Rigidbody2D rBody;


    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Called once per frame and is guaranteed to be consistent
    // Used for Physics calculations 
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Debug.Log("Horizontal value: " + moveHorizontal + " Vertical value: " + moveVertical);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Debug.Log(movement);

        rBody.velocity = movement * speed;

        // Restrict the Player from Leaving the Area 
        rBody.position = new Vector2(
            Mathf.Clamp(rBody.position.x, minX, maxX),   // Restrict X to minX and maxX
            Mathf.Clamp(rBody.position.y, minY, maxY)); //  Restrict Y to minY and maxY

    }
}


