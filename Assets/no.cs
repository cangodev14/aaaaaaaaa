using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no : MonoBehaviour {
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject opa;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        opa.SetActive(false);
        zabratmoney.alr = false;
        generator.podskazused = false;
    }
}
