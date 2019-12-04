using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
    public static int schet=0;
	// Use this for initialization
	void Start () {
        gameObject.GetComponent <TextMesh>().text= schet.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
