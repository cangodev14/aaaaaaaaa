using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using AppodealAds.Unity.Api;
using UnityEngine.SocialPlatforms;

public class calltip : MonoBehaviour {
    public GameObject callfon;
    private bool used;
    public AudioSource tidun;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public TextMesh varik;
    private int randomik;
    private int randomik2;
    private int randomik3;
    private float counter;
    private bool picked;
    public GameObject text;
    public Collider2D ad;


    void Start () {
        
        string appKey = "1022fdde81346de19a5a74fa7d7857cc86a069d27207ddd4";
        Appodeal.initialize(appKey, Appodeal.NON_SKIPPABLE_VIDEO, true);
        if (start.SSEC == true)
        {
            gameObject.SetActive(false);
            
        }
    }
    public void ShowRewardedAd()
    {
        if (Appodeal.isLoaded(Appodeal.NON_SKIPPABLE_VIDEO))
        {

            Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
            generator.podskazused = true;
            picked = true;
            tidun.Play();
            gameObject.GetComponent<Animator>().Play("ubiv");
            callfon.SetActive(true);
            used = true;
            p1.SetActive(false);
            p2.SetActive(false);
            p3.SetActive(false);
            p4.SetActive(false);
            p5.SetActive(false);
            randomik = Random.Range(1, 5);
            if (randomik == 4)
            {
                randomik2 = Random.Range(1, 4);
                if (generator.whichtrue == 1)
                {
                    if (randomik2 == 1)
                        varik.text = "A или B";
                    if (randomik2 == 2)
                        varik.text = "A или C";
                    if (randomik2 == 3)
                        varik.text = "A или D";
                }
                if (generator.whichtrue == 2)
                {
                    if (randomik2 == 1)
                        varik.text = "B или A";
                    if (randomik2 == 2)
                        varik.text = "B или C";
                    if (randomik2 == 3)
                        varik.text = "B или D";
                }
                if (generator.whichtrue == 3)
                {
                    if (randomik2 == 1)
                        varik.text = "C или A";
                    if (randomik2 == 2)
                        varik.text = "C или B";
                    if (randomik2 == 3)
                        varik.text = "C или D";
                }
                if (generator.whichtrue == 4)
                {
                    if (randomik2 == 1)
                        varik.text = "D или A";
                    if (randomik2 == 2)
                        varik.text = "D или B";
                    if (randomik2 == 3)
                        varik.text = "D или C";
                }
            }
            else
            {
                randomik3 = Random.Range(1, 5);
                if (generator.whichtrue == 1)
                {
                    if (randomik3 == 1)
                        varik.text = "A";
                    if (randomik3 == 2)
                        varik.text = "A";
                    if (randomik3 == 3)
                        varik.text = "A";
                    if (randomik3 == 4)
                        varik.text = "B";
                }
                if (generator.whichtrue == 2)
                {
                    if (randomik3 == 1)
                        varik.text = "B";
                    if (randomik3 == 2)
                        varik.text = "B";
                    if (randomik3 == 3)
                        varik.text = "B";
                    if (randomik3 == 4)
                        varik.text = "C";
                }
                if (generator.whichtrue == 3)
                {
                    if (randomik3 == 1)
                        varik.text = "C";
                    if (randomik3 == 2)
                        varik.text = "C";
                    if (randomik3 == 3)
                        varik.text = "C";
                    if (randomik3 == 4)
                        varik.text = "D";
                }

                if (generator.whichtrue == 4)
                {
                    if (randomik3 == 1)
                        varik.text = "D";
                    if (randomik3 == 2)
                        varik.text = "D";
                    if (randomik3 == 3)
                        varik.text = "D";
                    if (randomik3 == 4)
                        varik.text = "A";
                }
            }
        }
       
    }

    void FixedUpdate () {
        if (picked == true)
        { counter -= Time.deltaTime;
            if (counter < -4)
            {
                text.SetActive(true);
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
                    if (gameObject.name == "adcall")
                    {
                        ShowRewardedAd();
                    }
                    else {
                        ad.enabled = true;
                        generator.podskazused = true;
                    picked = true;
                    tidun.Play();
                    gameObject.GetComponent<Animator>().Play("ubiv");
                    callfon.SetActive(true);
                    used = true;
                    p1.SetActive(false);
                    p2.SetActive(false);
                    p3.SetActive(false);
                    p4.SetActive(false);
                    p5.SetActive(false);
                    randomik = Random.Range(1, 5);
                        if (randomik == 4)
                        {
                            randomik2 = Random.Range(1, 4);
                            if (generator.whichtrue == 1)
                            {
                                if (randomik2 == 1)
                                    varik.text = "A или B";
                                if (randomik2 == 2)
                                    varik.text = "A или C";
                                if (randomik2 == 3)
                                    varik.text = "A или D";
                            }
                            if (generator.whichtrue == 2)
                            {
                                if (randomik2 == 1)
                                    varik.text = "B или A";
                                if (randomik2 == 2)
                                    varik.text = "B или C";
                                if (randomik2 == 3)
                                    varik.text = "B или D";
                            }
                            if (generator.whichtrue == 3)
                            {
                                if (randomik2 == 1)
                                    varik.text = "C или A";
                                if (randomik2 == 2)
                                    varik.text = "C или B";
                                if (randomik2 == 3)
                                    varik.text = "C или D";
                            }
                            if (generator.whichtrue == 4)
                            {
                                if (randomik2 == 1)
                                    varik.text = "D или A";
                                if (randomik2 == 2)
                                    varik.text = "D или B";
                                if (randomik2 == 3)
                                    varik.text = "D или C";
                            }
                        }
                        else
                        {
                            randomik3 = Random.Range(1, 5);
                            if (generator.whichtrue == 1)
                            {
                                if (randomik3 == 1)
                                    varik.text = "A";
                                if (randomik3 == 2)
                                    varik.text = "A";
                                if (randomik3 == 3)
                                    varik.text = "A";
                                if (randomik3 == 4)
                                    varik.text = "B";
                            }
                            if (generator.whichtrue == 2)
                            {
                                if (randomik3 == 1)
                                    varik.text = "B";
                                if (randomik3 == 2)
                                    varik.text = "B";
                                if (randomik3 == 3)
                                    varik.text = "B";
                                if (randomik3 == 4)
                                    varik.text = "C";
                            }
                            if (generator.whichtrue == 3)
                            {
                                if (randomik3 == 1)
                                    varik.text = "C";
                                if (randomik3 == 2)
                                    varik.text = "C";
                                if (randomik3 == 3)
                                    varik.text = "C";
                                if (randomik3 == 4)
                                    varik.text = "D";
                            }

                            if (generator.whichtrue == 4)
                            {
                                if (randomik3 == 1)
                                    varik.text = "D";
                                if (randomik3 == 2)
                                    varik.text = "D";
                                if (randomik3 == 3)
                                    varik.text = "D";
                                if (randomik3 == 4)
                                    varik.text = "A";
                            }
                        }
                    }
                }
            }
        }
    }
}
