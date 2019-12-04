using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needmoney : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "600 000 POINTS\nNEEDED";
        else
            gameObject.GetComponent<TextMesh>().text = "НУЖНО 600 000 \n ДЛЯ ОТКРЫТИЯ";
    }
}
