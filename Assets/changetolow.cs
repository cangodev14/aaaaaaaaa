using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SleekRender
{
    public class changetolow : MonoBehaviour
    {
        public GameObject ddsadsa;
        // Start is called before the first frame update
        void Start()
        {
            if (PlayerPrefs.GetInt("wdt") == 0)
            {
                PlayerPrefs.SetInt("wdt", Screen.width);
                PlayerPrefs.SetInt("hgt", Screen.height);
            }
        }

        // Update is called once per frame
        void Update()
        {
       
        }
        void OnMouseDown()
        {
            Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetInt("wdt") / 2.5f), Mathf.RoundToInt(PlayerPrefs.GetInt("hgt") / 2.5f), true);
            ddsadsa.GetComponent<SleekRenderPostProcess>().enabled = false;
           
        }
    }
}