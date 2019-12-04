using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onlights : MonoBehaviour
{
    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;
    public GameObject l5;
    public GameObject l6;
    public GameObject l7;
    public GameObject l8;
    private bool f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (f == false)
        {
            l1.SetActive(true);
            l2.SetActive(true);
            l3.SetActive(true);
            l4.SetActive(true);
            l5.SetActive(true);
            l6.SetActive(true);
            l7.SetActive(true);
            l8.SetActive(true);
            f = true;
        }
        else
        {
            l1.SetActive(false);
            l2.SetActive(false);
            l3.SetActive(false);
            l4.SetActive(false);
            l5.SetActive(false);
            l6.SetActive(false);
            l7.SetActive(false);
            l8.SetActive(false);
            f = false;
        }
    }
}
