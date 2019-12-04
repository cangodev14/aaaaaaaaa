using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooselanguage : MonoBehaviour {
    public static bool isrussian;
    public GameObject shtuka;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("lang") == 1)
        {
            shtuka.transform.localPosition = new Vector3(-5.29f, 3.05f, 0);
            isrussian = false;
        }
        else
        {
            shtuka.transform.localPosition = new Vector3(-3.85f, 3.05f, 0);
            isrussian = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
       
	}
    private void OnMouseDown()
    {
        if (gameObject.name == "ENG")
        {
            PlayerPrefs.SetInt("lang",1);
            isrussian = false;
            shtuka.transform.localPosition = new Vector3(-5.29f, 3.05f, 0);
        }
        else
        {
            PlayerPrefs.SetInt("lang", 2);
            isrussian = true;
            shtuka.transform.localPosition = new Vector3(-3.85f, 3.05f, 0);
        }
    }
}
