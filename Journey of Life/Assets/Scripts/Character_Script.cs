using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Script : MonoBehaviour {

    private Rigidbody2D character;
    private bool isDead = false;
    private bool jumpReady = false;

    public float upForce = 250f;

	void Start ()
    {
        character = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( isDead == false)
        {
            if ( Input.GetKeyDown ("space") && jumpReady)
            {
                //character.velocity = Vector2.zero;
                character.AddForce(new Vector2(0, upForce));
                jumpReady = false;
            }
            if ( Input.GetKey ("right"))
            {
                character.AddForce(new Vector2(20, 0));
            }
        }
	}

    void OnCollisionEnter2D()
    {
        jumpReady = true;
    }
}
