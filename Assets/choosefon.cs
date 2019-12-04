using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choosefon : MonoBehaviour {
    public static int foncolor;
    public SpriteRenderer glavfon;
    public GameObject zamok;
    public TextMesh chislo;
    public TextMesh samo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    private void OnMouseDown()
    {
        if (gameObject.name == "none")
        {
            foncolor = 0;
            glavfon.color = Color.white;
            zamok.SetActive(false);
            chislo.gameObject.SetActive(false);
        }
        if (gameObject.name == "orange")
        {
            if (PlayerPrefs.GetInt("score") >= 350000)
            {
                foncolor = 1;
                glavfon.color = Color.Lerp(Color.red, Color.yellow, 0.5f);
                zamok.SetActive(false);
                chislo.gameObject.SetActive(false);
            }
            else
            {
                chislo.gameObject.SetActive(true);
                glavfon.color = Color.Lerp(Color.red, Color.yellow, 0.5f);
               zamok.SetActive(true);
                samo.text = "350,000";
            }
        }
        if (gameObject.name == "purple")
        {
           if (PlayerPrefs.GetInt("score") >= 800000)
            {
                foncolor = 2;
                glavfon.color = Color.magenta;
                zamok.SetActive(false);
                chislo.gameObject.SetActive(false);
            }
            else
            {
                chislo.gameObject.SetActive(true);
                glavfon.color = Color.magenta;
               zamok.SetActive(true);
                samo.text = "800,000";
           }
        }
        if (gameObject.name == "green")
        {
            if (PlayerPrefs.GetInt("score") >= 3000000)
            {
                foncolor = 3;
                glavfon.color = Color.green;
                zamok.SetActive(false);
                chislo.gameObject.SetActive(false);
            }
            else
            {
                chislo.gameObject.SetActive(true);
                glavfon.color = Color.green;
                zamok.SetActive(true);
                samo.text = "3,000,000";
            }
        }
    }
}
