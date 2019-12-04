using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {
    public static AsyncOperation AO;
    
    
	// Use this for initialization
	void Start () {
       
        
            Application.backgroundLoadingPriority = ThreadPriority.Low;
            AO = SceneManager.LoadSceneAsync("reloadorwhat");
            AO.allowSceneActivation = false;
           
        }
       
    
   
	
	// Update is called once per frame
	void Update () {
		
	}
}
