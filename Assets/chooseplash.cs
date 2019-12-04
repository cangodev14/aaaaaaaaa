using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseplash : MonoBehaviour {
    public static int plcolor;
    public SpriteRenderer glavcolor;
    public Sprite none;
    public Sprite orange;
    public Sprite purple;
    public Sprite green;
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
            plcolor = 0;
            glavcolor.sprite = none;
            zamok.SetActive(false);
            chislo.gameObject.SetActive(false);
        }
        if (gameObject.name == "orange")
        {
            if (PlayerPrefs.GetInt("score") >= 350000)
            {
                plcolor = 1;
                glavcolor.sprite = orange;
                zamok.SetActive(false);
                chislo.gameObject.SetActive(false);
            }
            else
            {
                chislo.gameObject.SetActive(true);
               glavcolor.sprite = orange;
                zamok.SetActive(true);
               samo.text = "350,000";
            }
        }
        if (gameObject.name == "purple")
        {
            if(PlayerPrefs.GetInt("score") >= 800000)
            {
                plcolor = 2;
                glavcolor.sprite = purple;
                zamok.SetActive(false);
                chislo.gameObject.SetActive(false);
            }
            else
            {
               chislo.gameObject.SetActive(true);
                glavcolor.sprite = purple;
                zamok.SetActive(true);
                samo.text = "800,000";
            }
        }
        if (gameObject.name == "green")
        {
            if (PlayerPrefs.GetInt("score") >= 3000000)
            {
                plcolor = 3;
                glavcolor.sprite = green;
                zamok.SetActive(false);
                chislo.gameObject.SetActive(false);
            }
            else
           {
                chislo.gameObject.SetActive(true);
               glavcolor.sprite = green;
               zamok.SetActive(true);
               samo.text = "3,000,000";
            }
        }
    }
}
