using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesgor : MonoBehaviour {
    public GameObject strelka;
    public static int nesgorkakaya;
    public static bool classicda;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        if (classicda == false)
        {
            if (gameObject.name == "5000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, -17.58f+2.5f,-28.61f);
                nesgorkakaya = 1;
            }
            if (gameObject.name == "10000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, -11.55f + 2.5f, -28.61f);
                nesgorkakaya = 2;
            }
            if (gameObject.name == "15000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, -5.69f + 2.5f, -28.61f);
                nesgorkakaya = 3;
            }
            if (gameObject.name == "25000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, -0.19f + 2.5f, -28.61f);
                nesgorkakaya = 4;
            }
            if (gameObject.name == "50000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, 4.7f + 2.5f, -28.61f);
                nesgorkakaya = 5;
            }
            if (gameObject.name == "100000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, 10.4f + 2.5f, -28.61f);
                nesgorkakaya = 6;
            }
            if (gameObject.name == "200000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, 15.7f + 2.5f, -28.61f);
                nesgorkakaya = 7;
            }
            if (gameObject.name == "400000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, 21.2f + 2.5f, -28.61f);
                nesgorkakaya = 8;
            }
            if (gameObject.name == "800000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, 26.5f + 2.5f, -28.61f);
                nesgorkakaya = 9;
            }
            if (gameObject.name == "1500000")
            {
                strelka.transform.localPosition = new Vector3(9.65f, 31.6f + 2.5f, -28.61f);
                nesgorkakaya = 10;
            }
        }
    }
}
