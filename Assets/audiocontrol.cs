using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiocontrol : MonoBehaviour {
    public AudioSource source;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;

    // Use this for initialization
    void Start () {
        if (score.schet < 15000)
            source.clip = one;
        if (score.schet >= 15000& score.schet < 3000000)
            source.clip = two;
        if (score.schet == 3000000)
            source.clip = three;
        source.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
