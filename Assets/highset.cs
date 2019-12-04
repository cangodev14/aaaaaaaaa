using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SleekRender
{
    public class medset : MonoBehaviour
    {
        public GameObject ddsadsa;
        // Start is called before the first frame update
      //  void Start()
       // {if(PlayerPrefs.GetInt("wid")=0)
        //    PlayerPrefs.SetInt("wid", Screen.width);
        //    PlayerPrefs.SetInt("hei", Screen.height);
      //  }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(PlayerPrefs.GetInt("fdsfsdf"));
        }
        void OnMouseDown()
        {
            Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetInt("wid") / 1.2f), Mathf.RoundToInt(Screen.height / 1.2f), true);
            ddsadsa.GetComponent<SleekRenderPostProcess>().enabled = true;
        }
    }
}