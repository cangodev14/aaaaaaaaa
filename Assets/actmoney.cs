using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actmoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("score") < 500000)
        {
            gameObject.SetActive(false);
        }
        else
            gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
