using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SleekRender
{
    public class highfuck : MonoBehaviour
    {
        public GameObject ddsadsa;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnMouseDown()
        {
            Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetInt("wdt")), Mathf.RoundToInt(PlayerPrefs.GetInt("hgt")), true);
            ddsadsa.GetComponent<SleekRenderPostProcess>().enabled =true;
            
        }
    }
}