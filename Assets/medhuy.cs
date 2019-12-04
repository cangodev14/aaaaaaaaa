using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SleekRender
{
    public class medhuy : MonoBehaviour
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
            Screen.SetResolution(Mathf.RoundToInt(PlayerPrefs.GetInt("wdt") / 1.4f), Mathf.RoundToInt(PlayerPrefs.GetInt("hgt") / 1.4f), true);
            ddsadsa.GetComponent<SleekRenderPostProcess>().enabled = false;
        }
    }
}