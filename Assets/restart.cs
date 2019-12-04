using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {
    public static bool secraz;
	// Use this for initialization
	void Start () {
        if (secraz == false)
        {
            SceneManager.UnloadScene(SceneManager.GetSceneByName("SampleScene"));
            secraz = true;
        }
        else
        {
            SceneManager.UnloadScene(SceneManager.GetSceneByName("reloadorwhat"));
            loadloader.loaded = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    private void OnMouseDown()
    {
        load.AO.allowSceneActivation = true;
        


    }
}
