using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using AppodealAds.Unity.Api;

public class zaltip : MonoBehaviour {
    public AudioSource tudin;
    public GameObject zalfon;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject firstp;
    public GameObject secp;
    public GameObject thirdp;
    public GameObject fourp;
    public Animator firsta;
    public Animator seca;
    public Animator thirda;
    public Animator foura;
    public TextMesh a;
    public TextMesh b;
    public TextMesh c;
    public TextMesh d;
    public Collider2D ad;

    private bool used;
    private float counter=4;
    private int sevenperc;

    // Use this for initialization
    void Start () {
        string appKey = "1022fdde81346de19a5a74fa7d7857cc86a069d27207ddd4";
        Appodeal.initialize(appKey, Appodeal.NON_SKIPPABLE_VIDEO, true);
    }
    public void ShowRewardedAd()
    {
        if (Appodeal.isLoaded(Appodeal.NON_SKIPPABLE_VIDEO))
        {

            Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
            Debug.Log("The ad was successfully shown.");
            generator.podskazused = true;
            used = true;
            tudin.Play();
            gameObject.GetComponent<Animator>().Play("ubiv");
            zalfon.SetActive(true);
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
            p5.SetActive(false);
            p6.SetActive(false);
        }
      

    }
    

    // Update is called once per frame
    void FixedUpdate () {
        if (start.SSEC == true)
        {
            gameObject.SetActive(false);
        }
        if (used == true)
        {
            counter -= Time.deltaTime;
            if (counter < 0)
            {
                Naznach();
                used = false;
            }
        }
	}
    private void OnMouseDown()
    {
        if (generator.podskazused == false)
        {
            if (onclick.already == false)
            {
                if (used == false)
                {
                    if (gameObject.name == "ad")
                    {
                        ShowRewardedAd();
                    }
                    else
                    {
                        generator.podskazused = true;
                        used = true;
                        tudin.Play();
                        gameObject.GetComponent<Animator>().Play("ubiv");
                        zalfon.SetActive(true);
                        p1.SetActive(false);
                        p2.SetActive(false);
                        p3.SetActive(false);
                        p4.SetActive(false);
                        p5.SetActive(false);
                        p6.SetActive(false);
                        ad.enabled = true;
                    }
                }
            }
        }
    }
    void Naznach()
    {
        
        firsta.gameObject.transform.localScale = new Vector3(1.22f,1,1);
        seca.gameObject.transform.localScale = new Vector3(1.22f, 1, 1);
        thirda.gameObject.transform.localScale = new Vector3(1.22f, 1, 1);
        foura.gameObject.transform.localScale = new Vector3(1.22f, 1, 1);
        firsta.gameObject.transform.position = new Vector3(firsta.gameObject.transform.position.x,0,0);
        seca.gameObject.transform.position = new Vector3(seca.gameObject.transform.position.x, 0, 0);
        thirda.gameObject.transform.position = new Vector3(thirda.gameObject.transform.position.x, 0, 0);
        foura.gameObject.transform.position = new Vector3(foura.gameObject.transform.position.x, 0, 0);
        firsta.speed = 0;
        seca.speed = 0;
        thirda.speed = 0;
        foura.speed = 0;
        firsta.enabled = false;
        seca.enabled = false;
        thirda.enabled = false;
        foura.enabled = false;

        int frperc = Random.Range(42,98);
            int secperc = Random.Range(0, 100-frperc);
            int thirdperc = Random.Range(0, 100 - (secperc+frperc));
            int fourperc = 100 - (thirdperc+secperc+frperc);
        if (generator.whichtrue == 1)
        {
            a.text = frperc.ToString() + "%";
            b.text = secperc.ToString() + "%";
            c.text = thirdperc.ToString() + "%";
            d.text = fourperc.ToString() + "%";
            firstp.transform.localScale = new Vector3(1,frperc*0.01f,1);
            firstp.transform.position = new Vector3(firstp.transform.position.x,-(0.31f*(10-frperc*0.1f)),1);
            secp.transform.localScale = new Vector3(1, secperc * 0.01f, 1);
            secp.transform.position = new Vector3(secp.transform.position.x, -(0.31f * (10 - secperc * 0.1f)), 1);
            thirdp.transform.localScale = new Vector3(1, thirdperc * 0.01f, 1);
            thirdp.transform.position = new Vector3(thirdp.transform.position.x, -(0.31f * (10 - thirdperc * 0.1f)), 1);
            fourp.transform.localScale = new Vector3(1, fourperc * 0.01f, 1);
            fourp.transform.position = new Vector3(fourp.transform.position.x, -(0.31f * (10 - fourperc * 0.1f)), 1);
        }
        if (generator.whichtrue == 2)
        {
            a.text = secperc.ToString() + "%";
            b.text = frperc.ToString() + "%";
            c.text = thirdperc.ToString() + "%";
            d.text = fourperc.ToString() + "%";
            firstp.transform.localScale = new Vector3(1, secperc * 0.01f, 1);
            firstp.transform.position = new Vector3(firstp.transform.position.x, -(0.31f * (10 - secperc * 0.1f)), 1);
            secp.transform.localScale = new Vector3(1, frperc * 0.01f, 1);
            secp.transform.position = new Vector3(secp.transform.position.x, -(0.31f * (10 - frperc * 0.1f)), 1);
            thirdp.transform.localScale = new Vector3(1, thirdperc * 0.01f, 1);
            thirdp.transform.position = new Vector3(thirdp.transform.position.x, -(0.31f * (10 - thirdperc * 0.1f)), 1);
            fourp.transform.localScale = new Vector3(1, fourperc * 0.01f, 1);
            fourp.transform.position = new Vector3(fourp.transform.position.x, -(0.31f * (10 - fourperc * 0.1f)), 1);
        }
        if (generator.whichtrue == 3)
        {
            a.text = thirdperc.ToString() + "%";
            b.text = secperc.ToString() + "%";
            c.text = frperc.ToString() + "%";
            d.text = fourperc.ToString() + "%";
            firstp.transform.localScale = new Vector3(1, thirdperc * 0.01f, 1);
            firstp.transform.position = new Vector3(firstp.transform.position.x, -(0.31f * (10 - thirdperc * 0.1f)), 1);
            secp.transform.localScale = new Vector3(1, secperc * 0.01f, 1);
            secp.transform.position = new Vector3(secp.transform.position.x, -(0.31f * (10 - secperc * 0.1f)), 1);
            thirdp.transform.localScale = new Vector3(1, frperc * 0.01f, 1);
            thirdp.transform.position = new Vector3(thirdp.transform.position.x, -(0.31f * (10 - frperc * 0.1f)), 1);
            fourp.transform.localScale = new Vector3(1, fourperc * 0.01f, 1);
            fourp.transform.position = new Vector3(fourp.transform.position.x, -(0.31f * (10 - fourperc * 0.1f)), 1);
        }
        if (generator.whichtrue == 4)
        {
            a.text = fourperc.ToString() + "%";
            b.text = secperc.ToString() + "%";
            c.text = thirdperc.ToString() + "%";
            d.text = frperc.ToString() + "%";
            firstp.transform.localScale = new Vector3(1, fourperc * 0.01f, 1);
            firstp.transform.position = new Vector3(firstp.transform.position.x, -(0.31f * (10 - fourperc * 0.1f)), 1);
            secp.transform.localScale = new Vector3(1, secperc * 0.01f, 1);
            secp.transform.position = new Vector3(secp.transform.position.x, -(0.31f * (10 - secperc * 0.1f)), 1);
            thirdp.transform.localScale = new Vector3(1, thirdperc * 0.01f, 1);
            thirdp.transform.position = new Vector3(thirdp.transform.position.x, -(0.31f * (10 - thirdperc * 0.1f)), 1);
            fourp.transform.localScale = new Vector3(1, frperc * 0.01f, 1);
            fourp.transform.position = new Vector3(fourp.transform.position.x, -(0.31f * (10 - frperc * 0.1f)), 1);
        }

    }
}
