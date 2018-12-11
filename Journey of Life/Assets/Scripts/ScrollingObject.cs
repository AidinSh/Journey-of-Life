using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    private Rigidbody2D path;

	void Start ()
    {
        path = GetComponent<Rigidbody2D>();
        path.velocity = new Vector2(-2f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
