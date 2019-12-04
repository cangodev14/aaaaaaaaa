using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sovr : MonoBehaviour {
    public GameObject polosa;
    private float counter;
    private bool changing;
    public GameObject x2button;
    public GameObject clas5;
    public GameObject clas100;
    public GameObject restr;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (changing == true)
        {
            polosa.transform.localPosition = Vector3.Lerp(polosa.transform.localPosition, new Vector3(polosa.transform.localPosition.x, 3.25f, 0), counter);
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
        clas100.SetActive(false);
        clas5.SetActive(false);
        nesgor.classicda = false;
        changing = true;
        x2button.GetComponent<Animator>().Play("tpslol");
    }
}
