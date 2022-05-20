using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {

    public float xSpeed;

    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x <= 9)
        {
            transform.position += new Vector3(xSpeed,0,0);
        }
	}
}
