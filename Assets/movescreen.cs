using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescreen : MonoBehaviour {
    public GameObject fon1;
    public GameObject fonperex;
    public static bool mozhno;
    public GameObject generatorsuka;
    public GameObject adsuka;





    // Use this for initialization
    void Start () {
        mozhno = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
    }
    private void OnMouseDown()
    {
        nesgor.classicda = false;
        fonperex.SetActive(true);
        fon1.GetComponent<Animator>().Play("New Animation");
        gameObject.GetComponent<Animator>().Play("away");
        mozhno = true;

        generatorsuka.SetActive(true);
        adsuka.SetActive(false);


    }
}
