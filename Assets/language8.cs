﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class language8 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "Your prize:";
        else
            gameObject.GetComponent<TextMesh>().text = "Ваш Выигрыш:";
    }
}