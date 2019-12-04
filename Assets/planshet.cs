using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planshet : MonoBehaviour {
    private float height;
    private float width;
    public TextMesh noadsbeatch;
    public GameObject polosa;
    public GameObject poloska;
    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 60;
        height = Screen.height;
        width = Screen.width;
        if ((width / height) < 1.4f)
        {
            gameObject.GetComponent<Animation>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            noadsbeatch.fontSize = 116;
            polosa.transform.localPosition = new Vector3(-6.14f, -3.76f, 0);


        }
        else
        {
            noadsbeatch.fontSize = 137;
            polosa.transform.localPosition = new Vector3(-6.14f, -3.12f, 0);
        }

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if ((width / height) < 1.4f)
        {
           
            if (gameObject.name == "damn")
                gameObject.GetComponent<Camera>().orthographicSize = 7.6f;
            else
                gameObject.GetComponent<Camera>().orthographicSize = 6f;
            if (gameObject.name == "654")
                poloska.transform.localPosition = new Vector3(0, -6.55f, 14.78f);
            if (gameObject.name == "fuck")
                gameObject.GetComponent<Camera>().orthographicSize = 6.8f;
        }
        //       Debug.Log(PlayerPrefs.GetInt("share"));

    }
}
