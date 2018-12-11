using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapitingObject : MonoBehaviour {

    private PolygonCollider2D groundColiider;
    private float groundHorizontalLenght;

	void Start ()
    {
        groundColiider = GetComponent<PolygonCollider2D>();
        groundHorizontalLenght = 19.2f;
	}
	
	
	void Update ()
    {
		if ( transform.position.x < -groundHorizontalLenght)
        {
            repositionObject();
        }
	}

    private void repositionObject()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLenght * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
