using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptzovik : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "Pleeeease leave us a rewiev,\n we would be very grateful to you!";
        else
            gameObject.GetComponent<TextMesh>().text = "Пожаааалуйста, оставьте нам отзыв,\n мы будем очень-преочень благодарны";
    }
}

