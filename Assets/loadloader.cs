using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadloader : MonoBehaviour {
    public static bool loaded;
	// Use this for initialization
	void Start () {
        if (loaded == false)
        {
            SceneManager.LoadSceneAsync("loader",LoadSceneMode.Additive);
            loaded = true;
            
        }
	}
	
	
	
}
