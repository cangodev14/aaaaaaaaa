using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableonnoads : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("noadsbg") == 14)
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
