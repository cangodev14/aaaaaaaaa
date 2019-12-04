using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class prefs : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<TextMesh>().text = PlayerPrefs.GetInt("score").ToString();
      //  Social.ReportScore(PlayerPrefs.GetInt("score"), "CggI1OH5jhoQAhAA", (bool success) => {
            // handle success or failure
      //  });

    }
       
      

        // Update is called once per frame
        void Update () {
       
    }
}
