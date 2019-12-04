using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goback : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    private bool tiknuto;
    private float counter = 3;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (tiknuto == true)
        {
            counter -= Time.deltaTime;
            if (counter < 0)
                gameObject.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        generator.podskazused = false;
        p1.SetActive(true);
        p2.SetActive(true);
        p3.SetActive(true);
        p4.SetActive(true);
        p5.SetActive(true);
        p6.SetActive(true);
        gameObject.GetComponent<Animator>().Play("goback");
        tiknuto = true;
    }
}
