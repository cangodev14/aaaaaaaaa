using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openshop : MonoBehaviour {
    public GameObject tekst;
    public GameObject shopik;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        tekst.SetActive(false);
        shopik.SetActive(true);
    }
}
