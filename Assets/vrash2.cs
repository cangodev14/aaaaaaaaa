﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrash2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 0, -0.2f);
    }
}