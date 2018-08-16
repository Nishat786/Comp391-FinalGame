using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public int playerspeed = 10;
    public bool facingRight = true;
    public int PlayerJumpPower = 1250;
    public float movex;

	//// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
        PlayerMove ();		
	}
    void PlayerMove()
    {
        movex = Input.GetAxis("Horizontal");
        if(movex < 0.0f && facingRight == false)
        {
            FlipPlayer ();
        }
        else if (movex > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(movex * playerspeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    void Jump() {

    }
    void FlipPlayer()
    {

    }
}
