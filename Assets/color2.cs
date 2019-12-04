using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (choosefon.foncolor == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            gameObject.GetComponent<Animator>().Play("red");
        }
        if (choosefon.foncolor == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.red, Color.yellow, 0.5f);
            gameObject.GetComponent<Animator>().Play("orange");
        }
        if (choosefon.foncolor == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;
            gameObject.GetComponent<Animator>().Play("purple");
        }
        if (choosefon.foncolor == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            gameObject.GetComponent<Animator>().Play("green");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
