using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class languagerestore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "RESTORE PURCHASES";
        else
            gameObject.GetComponent<TextMesh>().text = "ВОССТАНОВИТЬ ПОКУПКИ";
    }
}
