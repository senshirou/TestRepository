using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
    [SerializeField] GameObject cube1;
    [SerializeField] GameObject cube2;

    GameObject[] spaners = new GameObject[2];

    
    

	// Use this for initialization
	void Start () {
        spaners[0] = cube1;
        spaners[1] = cube2;
        spaners = GetComponents<GameObject>();
		
	}
	
	// Update is called once per frame
	void Update () {

        var v = Random.Range(0, spaners.Length);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spaners[v], transform.position, transform.rotation);
        }

        Debug.Log(v);

        
		
	}

    void Add2()
    {
        


    }
}
