using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magascontrol : MonoBehaviour
{
    public Sprite norm;
    public Sprite wrong;
    public GameObject suka;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("score") < 600000)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = wrong;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            suka.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = norm;
            gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
            gameObject.GetComponent<BoxCollider>().enabled = true;
            suka.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
