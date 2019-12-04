using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour {
   public static float counter;
    public GameObject textA;
    public GameObject textB;
    public GameObject textC;
    public GameObject textD;
    public GameObject asks;
    public Sprite none;
    public Sprite orange;
    public Sprite purple;
    public Sprite green;
    public GameObject tofind;
    public AudioSource hah;
    // Use this for initialization
    void Start () {
        counter = 11;
        if (chooseplash.plcolor == 0)
            gameObject.GetComponent<SpriteRenderer>().sprite = none;
        if (chooseplash.plcolor == 1)
            gameObject.GetComponent<SpriteRenderer>().sprite = orange;
        if (chooseplash.plcolor == 2)
            gameObject.GetComponent<SpriteRenderer>().sprite = purple;
        if (chooseplash.plcolor == 3)
            gameObject.GetComponent<SpriteRenderer>().sprite = green;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (start.SSEC == true)
        {
            counter -= Time.deltaTime * 5.5f;
        }
        else
        {
            if (generator.questpoporyad == 1)
                counter -= Time.deltaTime * 1.2f;
            if (generator.questpoporyad > 1 & generator.questpoporyad < 5)
                counter -= Time.deltaTime * 2.5f;
            if (generator.questpoporyad == 5)
                counter -= Time.deltaTime / 1.2f;
            if (generator.questpoporyad > 5 & generator.questpoporyad < 11)
                counter -= Time.deltaTime / 2;
            if (generator.questpoporyad > 10 & generator.questpoporyad < 15)
                counter -= Time.deltaTime;
            if (generator.questpoporyad == 15)
                counter -= Time.deltaTime;
        }

        if (counter < 5.2f & counter > 4.9f)
            asks.GetComponent<Animator>().Play("askmanfast");
        if (counter < 4.8f & counter > 4.5f)
        {
            tofind.SetActive(true);
            asks.SetActive(true);
            //asks.GetComponent<Animator>().Play("askmanfast");
        }
        if (counter < 4&counter>3)
            textA.SetActive(true);
        if (counter < 3 & counter > 2)
            textB.SetActive(true);
        if (counter < 2 & counter > 1)
            textC.SetActive(true);
        if (counter < 1 & counter > 0)
        {
            textD.SetActive(true);
            if (generator.questpoporyad < 4)
            {
                int l = Random.Range(0,2);
                if(l==0& start.SSEC == false)
                hah.Play();
            }
        }
    }
}
