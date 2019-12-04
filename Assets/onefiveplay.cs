using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onefiveplay : MonoBehaviour {
    public GameObject asks;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<AudioSource>().PlayDelayed(5);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
       
	}
}
