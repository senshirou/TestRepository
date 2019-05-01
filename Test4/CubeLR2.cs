using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLR2 : MonoBehaviour {

    private Vector3 defPosition;

	// Use this for initialization
	void Start () {

        defPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(defPosition.x + Mathf.PingPong(Time.time * 2f, 1), defPosition.y, defPosition.z);

	}
}
