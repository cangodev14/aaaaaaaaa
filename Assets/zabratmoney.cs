using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zabratmoney : MonoBehaviour {
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public static bool alr;
    public GameObject opa;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        if (alr == false)
        {
            if (onclick.already == false)
            {
                if (generator.podskazused == false)
                {
                    generator.podskazused = true;
                    alr = true;
                    a.SetActive(false);
                    b.SetActive(false);
                    c.SetActive(false);
                    d.SetActive(false);
                    opa.SetActive(true);
                }
            }
        }
    }
}
