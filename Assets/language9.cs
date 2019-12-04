using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class language9 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "TOTAL PRIZE";
        else
            gameObject.GetComponent<TextMesh>().text = "ОБЩИЙ СЧЕТ";
    }
}
