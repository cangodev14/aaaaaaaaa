using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class language10 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "BUY THE PREMIUM and turn off the ads";
        else
            gameObject.GetComponent<TextMesh>().text = "КУПИТЬ ПРЕМИУМ и отключить рекламу";
    }
}
