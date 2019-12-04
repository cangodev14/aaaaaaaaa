using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class langshit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "PLAY";
        else
            gameObject.GetComponent<TextMesh>().text = "ИГРАТЬ";
    }
}
