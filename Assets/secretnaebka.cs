﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretnaebka : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "opens the \n'SECRET\nMYSTERY\nTIP'";
        else
            gameObject.GetComponent<TextMesh>().text = "открывает \n'СЕКРЕТНУЮ\nТАЙНУЮ\nПОДСКАЗКУ'";
    }
}

