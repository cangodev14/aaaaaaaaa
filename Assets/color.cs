using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (choosefon.foncolor == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (choosefon.foncolor == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.red, Color.yellow, 0.5f);
        }
        if (choosefon.foncolor == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        if (choosefon.foncolor == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
