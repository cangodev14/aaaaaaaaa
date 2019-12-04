using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class bannerload : MonoBehaviour
{
    private float counter = 2;
    private bool blabla;

    // Use this for initialization
    void Start()
    {
       
      
    }
    private void FixedUpdate()
    {
        counter -= Time.deltaTime;
       
        
            if (counter < 0 & blabla == false)
            {
                int chance = Random.Range(1,5);

            if (PlayerPrefs.GetInt("naebka") > 4)
            {
                Appodeal.show(Appodeal.INTERSTITIAL);
                blabla = true;
            }
            else
            {
                blabla = true;
                PlayerPrefs.SetInt("naebka", PlayerPrefs.GetInt("naebka") + 1);
            }
        }
        
        
    }

    // Update is called once per frame
    
}
