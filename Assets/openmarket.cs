using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class openmarket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
       Device.RequestStoreReview();
         //Application.OpenURL("market://details?id=" + "com.cangodev.millionaire2020damn");
        // PlayerPrefs.SetInt("ocenka", 3);

    }
}
