using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classic : MonoBehaviour {
    public GameObject polosa;
    private float counter;
    private bool changing;
    public GameObject clas5;
    public GameObject clas100;
    public GameObject restr;

    public GameObject x2button;
    // Use this for initialization
    void Start()
    {

    }

    
    void FixedUpdate()
    {
        if (changing == true)
        {
            polosa.transform.localPosition = Vector3.Lerp(polosa.transform.localPosition, new Vector3(polosa.transform.localPosition.x, 2.26f, 0), counter);
            counter += Time.deltaTime*2;
            if (counter >= 1)
            {
                changing = false;
                counter = 0;
            }
        }

    }
    private void OnMouseDown()
    {
        restr.SetActive(false);
        clas100.SetActive(true);
        clas5.SetActive(true);
        nesgor.classicda = true;
        changing = true;
        x2button.GetComponent<Animator>().Play("ubiv");
        
    }
}