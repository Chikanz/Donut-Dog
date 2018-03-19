using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

    [Range(0.0f, 1.0f)]
    public float x, y, z;
    
    [Range(0, 100)]
    public float Speed;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(x * Speed, y * Speed, z * Speed);
	}
}
