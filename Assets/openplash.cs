using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openplash : MonoBehaviour {
    public GameObject foni;
    public GameObject plashki;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        foni.SetActive(false);
        plashki.SetActive(true);
    }
}
