using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realplus : MonoBehaviour
{
    public AudioSource tudin;
    // Start is called before the first frame update
    void Start()
    {
        if (start.SSEC == false)
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        gameObject.GetComponent<Animator>().Play("ubiv");
        vivod.cntbbb += 15;
        tudin.Play();
        gameObject.GetComponent<CircleCollider2D>().enabled = false;

    }
}
