using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openoptions : MonoBehaviour
{public GameObject shortline;
    private float counter =9999f;
    public AudioSource tudun;
    public GameObject onel;
    public GameObject twol;
   // public GameObject threel;
    public GameObject fourl;
   // public GameObject fourlhih;
    public GameObject engrus;
    public GameObject scenablya;
    public Material lighblue;
    public Material lighblue2;
    public Material pooval;
    public Material orange;
    public GameObject camera1;
    public GameObject vrs;
    public GameObject toedit;
    public GameObject generatorsuka;
    public GameObject bigscena;
   // public GameObject adsuka;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter < 0.28f & counter > 0)
        {
            twol.SetActive(true);
            lighblue2.color = Color.Lerp(Color.red, Color.yellow, 0.5f);
        }
        if (counter < 0.07f & counter>0)
        {
            // threel.SetActive(true);
            lighblue.color = Color.Lerp(Color.red, Color.yellow,0.5f);
        }
        if (counter < -0.08f &counter>-0.15f)
        {
            fourl.SetActive(true);
          //  fourlhih.SetActive(true);
            pooval.EnableKeyword("_EMISSION");
            scenablya.SetActive(true);
            camera1.GetComponent<Animator>().enabled = true;
            vrs.SetActive(true);
        }
        if((counter<-2) & (counter > -3f))
        {
            toedit.SetActive(true);
        }
    }
    void OnMouseDown()
    {
        counter = 0.7f;
        shortline.SetActive(false);
        engrus.SetActive(false);
        tudun.Play();
        orange.EnableKeyword("_EMISSION");
        nesgor.classicda = false;
        bigscena.SetActive(true);
        start.SSEC = false;
        
        generatorsuka.SetActive(true);
       // adsuka.SetActive(false);
    }
}
