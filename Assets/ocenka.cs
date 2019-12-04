using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class ocenka : MonoBehaviour {

	// Use this for initialization
	void Start () {
       // if (PlayerPrefs.GetInt("ocenka") != 3)
       // {
        //    int vera = Random.Range(0, 3);
         //   if (vera == 1)
         //   {
         //       gameObject.SetActive(true);
         //   }
         //   else
          //      gameObject.SetActive(false);
       // }
       // else
         //   gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
       Device.RequestStoreReview();
      //  Application.OpenURL("market://details?id=" + "com.cangodev.millionairepremium");
       // PlayerPrefs.SetInt("ocenka", 3);

    }
}
