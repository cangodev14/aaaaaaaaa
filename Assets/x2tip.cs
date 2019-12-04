using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2tip : MonoBehaviour {
    public AudioSource music;
    public GameObject tride;
    public AudioSource one;
    public AudioSource five;
    public AudioSource ten;
    private bool used;
    public static bool poraout;
	// Use this for initialization
	void Start () {
        if (nesgor.classicda == true)
            gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (poraout == true)
        {
            one.mute = false;
            five.mute = false;
            ten.mute = false;
            music.Stop();
        }
	}
    private void OnMouseDown()
    {
        if (generator.podskazused == false)
        {
            if (onclick.already == false)
            {
                if (used == false)
                {
                    generator.podskazused = true;
                    gameObject.GetComponent<Animator>().Play("ubiv");
                    used = true;
                    music.Play();
                    tride.SetActive(true);
                    one.mute = true;
                    five.mute = true;
                    ten.mute = true;
                    onclick.x2used = true;
                }
            }
        }
        
    }
}
