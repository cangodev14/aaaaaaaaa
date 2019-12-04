using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languageads : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
        {
            gameObject.GetComponent<TextMesh>().text = "DISABLE ADS";
            gameObject.GetComponent<TextMesh>().characterSize = 0.04f;
          //  gameObject.transform.localPosition = new Vector3(1.17f, 0, 0);
        }
        else
        {
            gameObject.GetComponent<TextMesh>().text = "ОТКЛЮЧИТЬ РЕКЛАМУ";
            gameObject.GetComponent<TextMesh>().characterSize = 0.03f;
            //gameObject.transform.localPosition = new Vector3(1.44f,0,0);
        }
    }
}
