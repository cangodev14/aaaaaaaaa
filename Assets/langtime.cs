using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class langtime : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "opens the \n'TIME TRIAL'";
        else
            gameObject.GetComponent<TextMesh>().text = "открывает \n'РЕЖИМ НА ВРЕМЯ'";
    }
}
