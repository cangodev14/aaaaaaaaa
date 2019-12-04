using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plus15sec : MonoBehaviour
{public static bool hah;
    private float low=10;
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
        if (hah == true)
        {
            low -= Time.deltaTime;
        }
        if (low < 0)
        {
            hah = false;
        }
    }
    void OnMouseDown()
    {
        gameObject.GetComponent<Animator>().Play("ubiv");
        hah = true;
        tudin.Play();
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }
}
