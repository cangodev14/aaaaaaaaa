using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class langnaebka : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lang") == 1)
            gameObject.GetComponent<TextMesh>().text = "Wanna Get 500.000 POINTS?\nShare the link of this game with your friend \nand if he downloads it you'll GET THE CASH!";
        else
            gameObject.GetComponent<TextMesh>().text = "Хочешь получить 500 000 очков?\nПоделись ссылкой на игру с другом,\n и если он её скачает, ты получишь награду!";
    }
}
