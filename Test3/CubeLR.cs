using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLR : MonoBehaviour {
    float x;
    float xx;
    float a;
    float c;
    Vector3 b;

	// Use this for initialization
	void Start () {

        a = 3f;
        c = 0.1f;
        
		
	}
	
	// Update is called once per frame
	void Update () {
        x =c *Mathf.Sin(Time.time * a);


       transform.position = new Vector3(x+transform.position.x,transform.position.y,transform.position.z);
		
	}
}
