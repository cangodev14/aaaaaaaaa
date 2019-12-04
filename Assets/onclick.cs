using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;



public class onclick : MonoBehaviour {

    public AudioSource mixer;
    public AudioClip submit;
    public AudioClip onefivewrong;
    public AudioClip onefivenice;
    public AudioClip sixchnice;
    public AudioClip sixchwrong;
    public AudioClip elevenchnice;
    public AudioClip elevenchwrong;
    public GameObject chosenA;
    public GameObject chosenB;
    public GameObject chosenC;
    public GameObject chosenD;
    public GameObject chosen;
    public GameObject asks;
    public AnimationClip fast;
    private bool rightorwhat;
    public GameObject shortsht;
    public TextMesh tottext;
    private GameObject chosenactually;
    public Material one;
    public Material two;
    public SpriteRenderer three;
    private bool otv;
    public static bool already;
    private float counter2;
    public static bool dlya50;
    private bool lose;
    public static bool x2used;
    public GameObject tride;
    public AudioSource odnp;
    public AudioSource sixblin;
    public AudioSource tenblin;
    private bool muted;
    public Animator cam;
    public static bool fff;
    public GameObject tofind;
    public GameObject fuck;
    public GameObject suck;
    public Material lgts;
    public Material lgts2;
    public Material lgts3;
    public Material lgts4;
    private bool holyfuck;
    public Material lgts5;
    private float counter9 = 0;
    public GameObject winms;
    private bool bobo;
    public float tillend;
    public static float raznic;
    public static bool shitat;
    public static bool shitat2;


    // Use this for initialization
    void Start() {
        counter2 = generator.kakoycount;
        already = false;
        one.SetColor("_EmissionColor", Color.cyan);
        two.SetColor("_EmissionColor", Color.cyan);
        Application.targetFrameRate = 60;
        gameObject.SetActive(false);
       
       

    }

    // Update is called once per frame

    void Update()
    {
        // ochkov = ochkov - Time.deltaTime;

        
        if (holyfuck == true)
        {
            counter9 += Time.deltaTime;
            lgts.color = Color.Lerp(lgts.color, Color.red, (counter9));
            lgts2.color = Color.Lerp(lgts2.color, Color.red, (counter9));
            lgts3.color = Color.Lerp(lgts3.color, Color.red, (counter9));
            lgts4.color = Color.Lerp(lgts4.color, Color.red, (counter9));
            lgts5.color = Color.Lerp(lgts5.color, Color.red, (counter9));
            //   three.color = Color.Lerp(Color.white, Color.red, -counter2 / 2);
        }
    }
    void FixedUpdate() {

        if (counter2 > -2.5f)
            dlya50 = false;
        if (otv == true)
            if (start.SSEC == true)
            {
                counter2 -= 3 * Time.deltaTime;
            }
            else
                counter2 -= Time.deltaTime;
        if (counter2 < 0)
        {
            shortsht.SetActive(false);
            if (rightorwhat == true)
            {

                cameracontrol.counter = 7;
                chosenactually.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.green, Color.white, Mathf.PingPong(Time.time, 0.6f));
                if (generator.questpoporyad < 5)
                    mixer.clip = onefivenice;
                if (generator.questpoporyad > 4 & generator.questpoporyad < 12)
                    mixer.clip = sixchnice;
                if (generator.questpoporyad > 11)
                    mixer.clip = elevenchnice;

                if (mixer.isPlaying == false)
                    mixer.Play();
                if (nesgor.classicda == true & generator.questpoporyad == 5)
                {
                    score.schet = 5000;
                }
                if (nesgor.classicda == true & generator.questpoporyad == 10)
                {
                    score.schet = 100000;
                }
                if (nesgor.nesgorkakaya == generator.questpoporyad - 4 & nesgor.classicda == false)
                {
                    if (nesgor.nesgorkakaya == 1)
                    {
                        score.schet = 5000;
                    }
                    if (nesgor.nesgorkakaya == 2)
                    {
                        score.schet = 10000;
                    }
                    if (nesgor.nesgorkakaya == 3)
                    {
                        score.schet = 15000;
                    }
                    if (nesgor.nesgorkakaya == 4)
                    {
                        score.schet = 25000;
                    }
                    if (nesgor.nesgorkakaya == 5)
                    {
                        score.schet = 50000;
                    }
                    if (nesgor.nesgorkakaya == 6)
                    {
                        score.schet = 100000;
                    }
                    if (nesgor.nesgorkakaya == 7)
                    {
                        score.schet = 200000;
                    }
                    if (nesgor.nesgorkakaya == 8)
                    {
                        score.schet = 400000;
                    }
                    if (nesgor.nesgorkakaya == 9)
                    {
                        score.schet = 800000;
                    }
                    if (nesgor.nesgorkakaya == 10)
                    {
                        score.schet = 1500000;
                    }

                }

                tride.SetActive(false);

                if (x2used == true)
                {
                    x2used = false;
                    x2tip.poraout = true;
                }
            }
            else
            {
                if (x2used == false)
                {
                    holyfuck = true;

                    three.color = Color.Lerp(Color.white, Color.red, -counter2 / 2);
                    chosenactually.SetActive(true);
                    chosenactually.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.green, Color.white, Mathf.PingPong(Time.time, 0.6f));

                    if (generator.questpoporyad < 5)
                        mixer.clip = onefivewrong;
                    if (generator.questpoporyad > 4 & generator.questpoporyad < 12)
                        mixer.clip = sixchwrong;
                    if (generator.questpoporyad > 11)
                        mixer.clip = elevenchwrong;
                    if (mixer.isPlaying == false)
                        mixer.Play();
                    lose = true;
                }
                else
                {

                    gameObject.GetComponent<TextMesh>().color = Color.Lerp(Color.red, Color.yellow, 0.5f);
                    if (generator.questpoporyad < 5)
                        mixer.clip = onefivewrong;
                    if (generator.questpoporyad > 4 & generator.questpoporyad < 12)
                        mixer.clip = sixchwrong;
                    if (generator.questpoporyad > 11)
                        mixer.clip = elevenchwrong;
                    if (mixer.isPlaying == false)
                        mixer.Play();
                    counter2 = 9999;
                    x2used = false;
                    gameObject.SetActive(false);
                    already = false;
                    tride.SetActive(false);
                    x2tip.poraout = true;
                }


            }
            if (counter2 < -2.1f & counter2 > -2.4f)
                muted = false;
            if (counter2 < -2.5f)
            {
                if (generator.questpoporyad >= 6 & generator.questpoporyad < 11)
                { if (muted == false)
                        sixblin.Play();
                }
                if (generator.questpoporyad >= 11)
                {
                    if (muted == false)
                        tenblin.Play();
                }

                if (generator.podskazused == true)
                    generator.podskazused = false;
                dlya50 = true;
                shortsht.SetActive(true);
                if (generator.questpoporyad == 1)
                {
                    tottext.text = "500";
                    score.schet = 0;
                }
                if (generator.questpoporyad == 2)
                    tottext.text = "1 000";
                if (generator.questpoporyad == 3)
                    tottext.text = "2 000";
                if (generator.questpoporyad == 4)
                    tottext.text = "3 000";
                if (generator.questpoporyad == 5)
                {
                    tottext.text = "5 000";
                    shortsht.GetComponent<Animator>().speed = 0.4f;
                    asks.GetComponent<Animator>().Play("askman");
                }
                if (generator.questpoporyad == 6)
                {
                    tottext.text = "10 000";
                    shortsht.GetComponent<Animator>().speed = 0.6f;
                }
                if (generator.questpoporyad == 7)
                    tottext.text = "15 000";
                if (generator.questpoporyad == 8)
                    tottext.text = "25 000";
                if (generator.questpoporyad == 9)
                    tottext.text = "50 000";
                if (generator.questpoporyad == 10)
                    tottext.text = "100 000";
                if (generator.questpoporyad == 11)
                    tottext.text = "200 000";
                if (generator.questpoporyad == 12)
                    tottext.text = "400 000";
                if (generator.questpoporyad == 13)
                    tottext.text = "800 000";
                if (generator.questpoporyad == 14)
                    tottext.text = "1 500 000";
                if (generator.questpoporyad == 15)
                {
                    tottext.text = "3 000 000";
                    if (rightorwhat == true) {
                        score.schet = 3000000;
                        cam.Play("winner");
                        winms.SetActive(true);
                        asks.SetActive(false);
                        if (bobo == false)
                        {
                            SceneManager.LoadScene("fucl", LoadSceneMode.Single);
                            bobo = true;
                        }

                    }
                    
                    // SceneManager.LoadScene("schet", LoadSceneMode.Additive);

                    PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + score.schet);

                }
                chosenactually.GetComponent<SpriteRenderer>().color = Color.white;
                rightorwhat = false;
                if (score.schet != 3000000)
                {
                    counter2 = generator.kakoycount;
                    otv = false;
                    already = false;
                    gameObject.GetComponent<TextMesh>().color = Color.Lerp(Color.red, Color.yellow, 0.5f);
                    asks.GetComponent<activate>().textA.SetActive(false);
                    asks.GetComponent<activate>().textB.SetActive(false);
                    asks.GetComponent<activate>().textC.SetActive(false);
                    asks.GetComponent<activate>().textD.SetActive(false);
                    asks.SetActive(false);
                    activate.counter = 8;
                    chosenA.SetActive(false);
                    chosenB.SetActive(false);
                    chosenC.SetActive(false);
                    chosenD.SetActive(false);
                    tofind.SetActive(false);
                    if (lose == true)
                    {

                        if (start.SSEC == true)
                        {
                        //    Lost();
                        }
                        else
                        {
                            SceneManager.LoadScene("schet", LoadSceneMode.Single);

                            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + score.schet);
                        }
                    }
                  //  Won();
                    GameObject.Find("gener").GetComponent<generator>().ChooseQuest();
                    if (generator.questpoporyad < 6)
                        //asks.GetComponent<Animator>().speed = 3;
                        if (generator.questpoporyad == 6)
                        {
                            activate.counter = 17;
                            asks.GetComponent<Animator>().speed = 0.9f;
                        }
                    if (generator.questpoporyad > 6 & generator.questpoporyad < 13)
                    {
                        activate.counter = 7;
                        asks.GetComponent<Animator>().speed = 1.8f;
                    }
                    if (generator.questpoporyad >= 13)
                    {
                        activate.counter = 7;
                        asks.GetComponent<Animator>().speed = 1.8f;
                        // asks.GetComponent<Animator>().speed = 1.3f;
                    }

                    asks.SetActive(true);

                }




            }
        }



    }
    void Lost()
    {
        vivod.cntbbb-= 7.8f;
        raznic = 0;
        shitat = false;
    }
    void Won()
    {
        vivod.cntbbb += 1.4f;
        if (shitat == false)
            shitat = true;
        else
        {
            shitat = false;
            shitat2 = true;
        }
        }
    
    
    private void OnMouseUp()
    {
        if (generator.questpoporyad >= 6& generator.questpoporyad < 13)
        {
            cam.Play("osnova");
            fuck.SetActive(false);
            suck.SetActive(true);
            fff = true;
        }
        if (generator.questpoporyad > 12 & generator.questpoporyad < 16)
        {
            cam.Play("frontved");
            fuck.SetActive(true);
            suck.SetActive(false);
            GameObject.Find("front").GetComponent<repliccontrol>().ChooseRep();
            fff = true;
        }

        cameracontrol.counter = 400;
        if (activate.counter < 1)
        {
            if (already == false)
            {
                if (generator.whichtrue == 1)
                    chosenactually = chosenA;
                if (generator.whichtrue == 2)
                    chosenactually = chosenB;
                if (generator.whichtrue == 3)
                    chosenactually = chosenC;
                if (generator.whichtrue == 4)
                    chosenactually = chosenD;
                if (gameObject.name=="A"&generator.whichtrue==1)
                {
                    rightorwhat = true;
                    Won();

                }
                if (gameObject.name == "A" & generator.whichtrue != 1)
                {
                    rightorwhat = false;
                    Lost();
                }
                if (gameObject.name == "B" & generator.whichtrue == 2)
                {
                    rightorwhat = true;
                    Won();

                }
                if (gameObject.name == "B" & generator.whichtrue != 2)
                {
                    rightorwhat = false;
                    Lost();
                }
                if (gameObject.name == "C" & generator.whichtrue == 3)
                {
                    rightorwhat = true;
                    Won();
                }
                if (gameObject.name == "C" & generator.whichtrue != 3)
                {
                    rightorwhat = false;
                    Lost();
                }
                if (gameObject.name == "D" & generator.whichtrue == 4)
                {
                    rightorwhat = true;
                    Won();
                }
                if (gameObject.name == "D" & generator.whichtrue != 4)
                {
                    rightorwhat = false;
                    Lost();
                }
                
                if (generator.questpoporyad >= 6 & generator.questpoporyad < 11)
                {
                    sixblin.Stop();
                    muted = true;
                }
                if (generator.questpoporyad >=11)
                {
                    tenblin.Stop();
                    muted = true;
                }
                mixer.clip = submit;
                mixer.Play();
                counter2 = generator.kakoycount;
                already = true;
                otv = true;
                chosen.SetActive(true);
                gameObject.GetComponent<TextMesh>().color = Color.white;
            }
        }
    }
}
