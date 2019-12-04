using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
    public GameObject fon1;
    public GameObject fon2;
    public AudioSource ft;
    public AudioSource intriga;
    public GameObject asks;
    private Vector3 velocity;
    public GameObject fonodin;
    public Animator goaway;
    public GameObject toedit;
    public Animator introcamera;
    public GameObject highcamera;
    private float cnt2=4;
    private bool aaaaa;
    public GameObject camcontrol;
    public Animator p1;
    public Animator p2;
    public Animator p3;
    public Animator p4;
    public Animator p5;
    public Animator p6;
    public Material projs;
    public Material pupirki;
    public GameObject txt1;
    public GameObject passhole;
    public GameObject sasshole;
    public static bool SSEC;
    public Material op;
    public Material opq;
    public Material opqe;
    public Material awplego;
    private float countersuka=4;
    public GameObject tttru;
    public GameObject txt2;
    public GameObject rrrrr;
    public GameObject bebebe;
    public GameObject textska;
    public AudioSource aplodiki;






    // Use this for initialization

    void Start() {
        velocity = Vector3.zero;
     

    }
    void Awake()
    {
        projs.color = Color.black;
        score.schet = 0;
        onclick.shitat = false;
        onclick.shitat2 = false;
        vivod.mezdu = 0;
        countersuka = 4;
        tttru.SetActive(false);
        txt2.SetActive(false);
        asks.SetActive(false);
    }

	
	// Update is called once per frame
	void Update () {
        if (SSEC == true)
        {
            
            generator.kakoycount = 0.1f;
           
            countersuka -= Time.deltaTime;
            if (countersuka < 0)
            {
                asks.SetActive(true);
                asks.GetComponent<Animator>().speed = 1.6f;
                tttru.SetActive(true);
                txt2.SetActive(true);
                
            }
        }
        if (aaaaa == true)
        {
            cnt2 -= Time.deltaTime;
            if (cnt2 < 4f)
            {
                if (cnt2 > 0)
                {//if (1/(Mathf.Sqrt(cnt2))<35)
                    //pupirki.SetTextureScale("_MainTex", new Vector2(10/ (Mathf.Sqrt(cnt2)), 10/(Mathf.Sqrt(cnt2))));
                }
                {
                    if (cnt2 < 0)
                    {
                        gameObject.SetActive(false);
                        
                    }
                    highcamera.SetActive(true);
                    projs.color = Color.Lerp(Color.white, Color.black, (cnt2 / 4)+0.4f);
                    
                }
            }
            
        }
	}
    private void OnMouseDown()
    {
        if (aaaaa == false)
        {if (gameObject.name == "time")
            {
                txt1.SetActive(true);
               
                SSEC = true;
                op.color = Color.red;
                opq.color = Color.red;
                opqe.color = Color.red;
                awplego.color = Color.red;
                txt2.GetComponent<TextMesh>().text = "0";
                score.schet = 0;
                onclick.shitat = true;
                onclick.shitat2 = false;
                vivod.mezdu = 0;
                countersuka = 4;
            }
        else
            {

                SSEC = false;
                vivod.cntbbb = 101;
                onclick.shitat = false;
                onclick.shitat2 = true;
            }
            aaaaa = true;
            fon2.SetActive(true);
            fon1.GetComponent<Animator>().Play("fonmovedal");
            aplodiki.Play();
            gameObject.GetComponent<Animator>().Play("away");
            ft.Stop();
            intriga.Play();
            if (SSEC == true)
            {

            }
            else
            {
                asks.SetActive(true);
                asks.GetComponent<Animator>().Play("asksman");
            }
            fonodin.SetActive(false);
            goaway.Play("2scene2");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            toedit.SetActive(false);
            movescreen.mozhno = true;
            introcamera.Play("introanim2");
            camcontrol.SetActive(true);
            p1.enabled = true;
            p2.enabled = true;
            p3.enabled = true;
            p4.enabled = true;
            p5.enabled = true;
            p6.enabled = true;
            passhole.SetActive(true);
            sasshole.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled =false;
            rrrrr.SetActive(false);
            bebebe.SetActive(false);
        }
    }
    
}
