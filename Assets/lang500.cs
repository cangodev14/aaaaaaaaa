using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lang500 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "gives a chance to\nuse 50 on 50 tip\none more time";
        else
            gameObject.GetComponent<TextMesh>().text = "даёт возможность\nиспользовать подсказку\n50 на 50 еще один раз";
    }
}
