using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomanimka : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Animator>().speed = Random.Range(0.1f,1.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
