using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour {

    public GameObject myCube;
    public Vector3 rotationVector;
    // Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        myCube.transform.eulerAngles += rotationVector;
    }
}
