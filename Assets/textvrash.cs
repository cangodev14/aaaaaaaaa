using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textvrash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        gameObject.transform.Rotate(Vector3.Lerp(new Vector3(0, -0.03f, 0), new Vector3(0, 0.03f, 0), Mathf.PingPong(Time.time/4, 1)));
	}
}
