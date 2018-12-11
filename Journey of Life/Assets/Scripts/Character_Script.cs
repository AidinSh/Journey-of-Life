using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Script : MonoBehaviour {

    private Rigidbody2D character;
    private bool isDead = false;
    private bool jumpReady = false;
    private Animator anim;
    private bool onLand;

    public float upForce = 250f;

	void Start ()
    {
        character = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if ( isDead == false)
        {
            if (Input.touchCount > 0 && jumpReady)
               // if ( Input.GetKeyDown ("space") && jumpReady)
            {
                //character.velocity = Vector2.zero;
                character.AddForce(new Vector2(0, upForce));
                jumpReady = false;
                onLand = false;
                anim.SetTrigger("Jump");
            }
            if ( Input.GetKey ("right"))
            {
                character.AddForce(new Vector2(20, 0));
            }
           // if (onLand)
           // {
            //    anim.SetTrigger("Land");
           // }
        }
	}

    void OnCollisionEnter2D()
    {
        jumpReady = true;
        anim.SetTrigger("Land");
    }
   // private void OnCollisionExit2D()
    //{
      //  anim.SetTrigger("Jump");
    //}
}
