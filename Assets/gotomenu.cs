using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotomenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
       // restart.secraz = false;
        SceneManager.LoadScene("SampleScene");
        loadloader.loaded = false;
        score.schet = 0;
       // start.SSEC = true;
        
    }
}
