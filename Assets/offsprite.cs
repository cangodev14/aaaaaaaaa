using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offsprite : MonoBehaviour {
    private float counter=3;
    public GameObject high;
    public GameObject low;
	// Use this for initialization
	void Start () {
        score.schet = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        counter -= Time.deltaTime;
        if (counter < 0)
        {
            
            gameObject.GetComponent<Animator>().enabled = false;
            low.GetComponent<Animator>().enabled = false;
            high.GetComponent<Animator>().enabled = false;
        }
	}
}
