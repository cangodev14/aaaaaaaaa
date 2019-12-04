using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotomenuff : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "go back to main menu";
        else
            gameObject.GetComponent<TextMesh>().text = "назад в меню";
    }
}
