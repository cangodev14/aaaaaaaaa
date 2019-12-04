using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppodealAds.Unity.Api;

public class generator : MonoBehaviour
{
    public TextAsset ez;
    public TextAsset med;
    public TextAsset hard;
    public TextAsset final;
    public TextAsset ezeng;
    public TextAsset medeng;
    private int chislostrok;
    private string randomquest;
    private string[] numberQuest;
    private string[] engquests;
    private string[] vars;
    private string questsam;
    public GameObject polotno;
    private string As;
    private string Bs;
    private string Cs;
    private string Ds;
    public TextMesh question;
    public TextMesh A;
    public TextMesh B;
    public TextMesh C;
    public TextMesh D;
    public static int questpoporyad;
    private string chosenstroka;
    private string questionitogo;
    private bool tomove;
    public static int whichtrue;
    private int numberofstroka;
    public GameObject odinp;
    public GameObject shestc;
    private float counter;
    public static float kakoycount;
    private string previous;
    private string seichas;
    public AudioSource fivewin;
    public static bool podskazused;
    public GameObject ten;
    private bool mmm;
    private int kakoytru;
    private bool isPaused = false;
    private bool ekbabay;
    public Animator das;
    private float counter9 = 0;
    private float counter91 = 0;
    private bool shit;
    public  Material lgts;
    public  Material lgts2;
    public  Material lgts3;
    public  Material lgts4;
    public  Material lgts5;
    private bool fuck;
    public int ss;



    public void ChooseSobsna()
    {

        if (chooselanguage.isrussian == true)
        {
            numberQuest = ez.text.Split('\r');
            previous = "///";
            chislostrok = numberQuest.Length;
            questpoporyad = 0;
            ChooseQuest();
        }
        else
        {
            engquests = ezeng.text.Split('\r');
            questpoporyad = 0;
            ChooseQuest();
        }
    }


   // void OnApplicationFocus(bool focusStatus)
  //  {
        
      //  {
        //    if (isPaused == false)
        //    isPaused = true;
     //   else
        //{
         //   if (focusStatus == true & ekbabay == false)
          //  {

                  //  Appodeal.show(Appodeal.INTERSTITIAL);
            //        isPaused = false;
           //         ekbabay = true;
        //        }
        //    }
      //  }
    //}

    // void OnApplicationPause(bool pauseStatus)
    // {
    //     isPaused = pauseStatus;
    //  }









    void Update()
    { //questpoporyad=ss;
        // if (isPaused == true)
        //  {
        //     Appodeal.show(Appodeal.INTERSTITIAL);
        //     isPaused = false;

        
        if (shit == true)
        {
            counter9 += Time.deltaTime;
          
            
                lgts.color = Color.Lerp(Color.Lerp(Color.red, Color.yellow, 0.5f), Color.blue, counter9);
                lgts2.color = Color.Lerp(Color.Lerp(Color.red, Color.yellow, 0.5f), Color.blue, counter9);
                lgts3.color = Color.Lerp(Color.Lerp(Color.red, Color.yellow, 0.5f), Color.blue, counter9);
                lgts4.color = Color.Lerp(Color.Lerp(Color.red, Color.yellow, 0.5f), Color.blue, counter9);
                lgts5.color = Color.Lerp(Color.Lerp(Color.red, Color.yellow, 0.5f), Color.blue, counter9 );
            
        }
        if (fuck == true)
        {
            
            counter91 += Time.deltaTime;
            
           
                lgts.color = Color.Lerp( Color.blue,Color.red, counter91);
                lgts2.color = Color.Lerp( Color.blue, Color.red, counter91);
                lgts3.color = Color.Lerp( Color.blue, Color.red, counter91);
                lgts4.color = Color.Lerp( Color.blue, Color.red, counter91);
                lgts5.color = Color.Lerp( Color.blue, Color.red, counter91);
            
        }
        if (movescreen.mozhno == true & mmm == false)
        {
            ChooseSobsna();
            mmm = true;
        }
        Vector3 current = polotno.transform.localPosition;
        Vector3 target = new Vector3(0.031f, 1.77f - questpoporyad * 0.262f, 0);
        if (tomove == true)
        {

            polotno.transform.localPosition = Vector3.Lerp(current, target, counter);
            counter += Time.deltaTime / 9;
            if (counter >= 1)
                tomove = false;
        }

    }
    public void ChooseQuest()
    {
        if (start.SSEC == true)
        {
            questpoporyad += 0;
        }else
        questpoporyad += 1;
        ekbabay = false;
        Vector3 current = polotno.transform.localPosition;
        Vector3 target = new Vector3(0.031f, 1.77f - questpoporyad * 0.262f, 0);
        tomove = true;
        counter = 0;


        if (questpoporyad <= 4)
        {
           if (start.SSEC == true)
            {
                generator.kakoycount = 0.1f;
            }else
            kakoycount = 1.5f;
        }

        if (questpoporyad == 6)
        {
            das.Play("5000");
            fivewin.Play();
            kakoycount = 22f;
            odinp.SetActive(false);
            shestc.SetActive(true);
            shestc.GetComponent<AudioSource>().PlayDelayed(9);
            shit = true;
            if (PlayerPrefs.GetInt("share") != 0& PlayerPrefs.GetInt("nb")!=333)
            {
                PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 500000);
                PlayerPrefs.SetInt("nb", 333);
            }

        }
        if (questpoporyad == 6)
        {
            if (PlayerPrefs.GetInt("naebka") > 4)
            {
                int randomchik = Random.Range(0, 5);
                if (randomchik > 1)
                {
                    Appodeal.show(Appodeal.INTERSTITIAL);
                }
            }

        }
        if (questpoporyad == 10)
        {
            
            if (PlayerPrefs.GetInt("naebka") > 4)
            {
                Appodeal.show(Appodeal.INTERSTITIAL);

            }
        }
        if (questpoporyad == 14)
        {
            if (PlayerPrefs.GetInt("naebka") > 4)
            {
                Appodeal.show(Appodeal.INTERSTITIAL);
            }
        }
        if (questpoporyad == 11)
        {
            fuck = true; if (start.SSEC == true)
            {
                generator.kakoycount = 0.1f;
            }else
            kakoycount = 3f;
            shestc.SetActive(false);
            ten.SetActive(true);
            ten.GetComponent<AudioSource>().PlayDelayed(1);

        }

        if (questpoporyad > 5 & questpoporyad <= 10)
        {
            if (start.SSEC == true)
            {
                generator.kakoycount = 0.1f;
            }
            else
                kakoycount = 3f;
            if (chooselanguage.isrussian == true)
            {
                numberQuest = med.text.Split('\r');


                chislostrok = numberQuest.Length;
            }
        }
        if (questpoporyad > 10 & questpoporyad < 15)
        {
            if (start.SSEC == true)
            {
                generator.kakoycount = 0.1f;
            }
            else
                kakoycount = 5;
            if (chooselanguage.isrussian == true)
            {
                numberQuest = hard.text.Split('\r');

                chislostrok = numberQuest.Length;
            }
        }
        if (questpoporyad == 15)
        {
            kakoycount = 6;
            if (chooselanguage.isrussian == true)
            {
                numberQuest = final.text.Split('\r');

                chislostrok = numberQuest.Length;
            }
        }
        if (chooselanguage.isrussian == true)
            numberofstroka = Random.Range(0, numberQuest.Length - 7);
        if (chooselanguage.isrussian == true)
            Analyze();
        else
            Vibor();


    }
    public void Vibor()
    {
        if (questpoporyad < 5)
            engquests = ezeng.text.Split('\r');
        if (questpoporyad > 4)
            engquests = medeng.text.Split('\r');
        questsam = engquests[Random.Range(1, engquests.Length)];
        /* question.text=questsam.Substring(0,questsam.IndexOf('?')+1);

          if (questsam.Substring(questsam.Length - 1, 1) == "1")
              whichtrue = 1;
          if (questsam.Substring(questsam.Length - 1, 1) == "2")
              whichtrue = 2;
          if (questsam.Substring(questsam.Length - 1, 1) == "3")
              whichtrue = 3;
          if (questsam.Substring(questsam.Length - 1, 1) == "4")
              whichtrue = 4;
          questsam = questsam.Substring(questsam.IndexOf('?') + 1,questsam.Length- questsam.IndexOf('?')-1);
          int counterobr = 0;
          counterobr = questsam.IndexOf('?');
       questsam = questsam.Substring(2);
          if (questsam.StartsWith("#"))
              questsam.Remove(0,1);
          int resh = questsam.IndexOf('#');
          counterobr = questsam.IndexOf('#');
          A.text = questsam.Substring(0,resh);
          Debug.Log(questsam);
          resh = questsam.IndexOf('#');

          questsam = questsam.Substring(resh+3,questsam.Length-counterobr-4);
          resh = questsam.IndexOf('#');
          counterobr = questsam.IndexOf('#');
          B.text = questsam.Substring(0, resh);
          resh = questsam.IndexOf('#');
          questsam = questsam.Substring(resh + 3, questsam.Length - counterobr-4);
          resh = questsam.IndexOf('#');
          counterobr = questsam.IndexOf('#');
          C.text = questsam.Substring(0, resh);
          resh = questsam.IndexOf('#');
          questsam = questsam.Substring(resh + 3, questsam.Length - counterobr - 4);
          resh = 0;
          D.text = questsam;*/
        if (questsam.Substring(questsam.Length - 1, 1) == "1")
            whichtrue = 1;
        if (questsam.Substring(questsam.Length - 1, 1) == "2")
            whichtrue = 2;
        if (questsam.Substring(questsam.Length - 1, 1) == "3")
            whichtrue = 3;
        if (questsam.Substring(questsam.Length - 1, 1) == "4")
            whichtrue = 4;
        questsam.Trim(' ');
        int resh = questsam.IndexOf('?');
        question.text = questsam.Remove(resh + 1, questsam.Length - resh - 1);
        questsam = questsam.Remove(0, resh + 2);
        resh = questsam.IndexOf('#');
        questsam = questsam.Remove(resh, 1);
        questsam.TrimStart('#');
        //Debug.Log(questsam);
        resh = questsam.IndexOf('#');
        A.text = questsam.Remove(resh, questsam.Length - resh);
        questsam = questsam.Remove(0, resh + 3);
        questsam.TrimStart('#');
        // Debug.Log(questsam);
        resh = questsam.IndexOf('#');
        B.text = questsam.Remove(resh, questsam.Length - resh);
        questsam = questsam.Remove(0, resh + 3);
        questsam.TrimStart('#');
        Debug.Log(questsam);
        resh = questsam.IndexOf('#');
        C.text = questsam.Remove(resh, questsam.Length - resh);
        questsam = questsam.Remove(0, resh + 3);
        questsam.TrimStart('#');
        Debug.Log(questsam);
        resh = questsam.IndexOf('#');
        D.text = questsam.Remove(resh, questsam.Length - resh);
        questsam = questsam.Remove(0, resh + 3);
    }
    public void Analyze()
    {

        chosenstroka = numberQuest[numberofstroka];

        if (chosenstroka.EndsWith("#"))
        {
            seichas = questionitogo;
            if (seichas != previous)
            {
                questionitogo = chosenstroka;
                ChooseVars();
                previous = seichas;
            }
            else
            {
                numberofstroka += 1;
                Analyze();
            }



        }
        else
        {

            numberofstroka += 1;
            Analyze();
        }


    }
    public void ChooseVars()
    {
        string finaltextofquestion = questionitogo.Remove(1, 1);
        if (finaltextofquestion.Length > 52)
        {
            string promez = finaltextofquestion.Remove(0, 38);
            int indexof = promez.IndexOf(" ");
            finaltextofquestion = finaltextofquestion.Insert(38 + indexof, "\n");
        }
        question.text = finaltextofquestion.Remove(finaltextofquestion.Length - 1, 1);
        As = (numberQuest[numberofstroka + 1]).Remove(0, 2);
        Bs = (numberQuest[numberofstroka + 2]).Remove(0, 2);
        Cs = (numberQuest[numberofstroka + 3]).Remove(0, 2);
        Ds = (numberQuest[numberofstroka + 4]).Remove(0, 2);
        As = As.Remove(As.Length - 1, 1);
        Bs = Bs.Remove(Bs.Length - 1, 1);
        Cs = Cs.Remove(Cs.Length - 1, 1);
        Ds = Ds.Remove(Ds.Length - 1, 1);

        ShakeAndNazn();
    }
    public void ShakeAndNazn()
    {

        if (As.Length > 14)
        {
            A.transform.localScale = new Vector3(1 - (As.Length * 0.005f), 1, 0);
            B.transform.localScale = new Vector3(1 - (As.Length * 0.005f), 1, 0);
            C.transform.localScale = new Vector3(1 - (As.Length * 0.005f), 1, 0);
            D.transform.localScale = new Vector3(1 - (As.Length * 0.005f), 1, 0);
        }
        else
        {
            A.transform.localScale = new Vector3(1, 1, 0);
            B.transform.localScale = new Vector3(1, 1, 0);
            C.transform.localScale = new Vector3(1, 1, 0);
            D.transform.localScale = new Vector3(1, 1, 0);
        }
        if (Bs.Length > 14)
        {

            A.transform.localScale = new Vector3(1 - (Bs.Length * 0.005f), 1, 0);
            B.transform.localScale = new Vector3(1 - (Bs.Length * 0.005f), 1, 0);
            C.transform.localScale = new Vector3(1 - (Bs.Length * 0.005f), 1, 0);
            D.transform.localScale = new Vector3(1 - (Bs.Length * 0.005f), 1, 0);
        }
        else
        {
            A.transform.localScale = new Vector3(1, 1, 0);
            B.transform.localScale = new Vector3(1, 1, 0);
            C.transform.localScale = new Vector3(1, 1, 0);
            D.transform.localScale = new Vector3(1, 1, 0);
        }
        if (Cs.Length > 14)
        {

            A.transform.localScale = new Vector3(1 - (Cs.Length * 0.005f), 1, 0);
            B.transform.localScale = new Vector3(1 - (Cs.Length * 0.005f), 1, 0);
            C.transform.localScale = new Vector3(1 - (Cs.Length * 0.005f), 1, 0);
            D.transform.localScale = new Vector3(1 - (Cs.Length * 0.005f), 1, 0);
        }
        else
        {
            A.transform.localScale = new Vector3(1, 1, 0);
            B.transform.localScale = new Vector3(1, 1, 0);
            C.transform.localScale = new Vector3(1, 1, 0);
            D.transform.localScale = new Vector3(1, 1, 0);
        }
        if (Ds.Length > 14)
        {

            A.transform.localScale = new Vector3(1 - (Ds.Length * 0.005f), 1, 0);
            B.transform.localScale = new Vector3(1 - (Ds.Length * 0.005f), 1, 0);
            C.transform.localScale = new Vector3(1 - (Ds.Length * 0.005f), 1, 0);
            D.transform.localScale = new Vector3(1 - (Ds.Length * 0.005f), 1, 0);
        }
        else
        {
            A.transform.localScale = new Vector3(1, 1, 0);
            B.transform.localScale = new Vector3(1, 1, 0);
            C.transform.localScale = new Vector3(1, 1, 0);
            D.transform.localScale = new Vector3(1, 1, 0);
        }
        int shakeskem = Random.Range(1, 5);
        if (shakeskem == 1)
        {
            whichtrue = 1;
            A.text = As;
            B.text = Bs;
            C.text = Cs;
            D.text = Ds;
        }
        if (shakeskem == 2)
        {
            whichtrue = 2;
            A.text = Bs;
            B.text = As ;
            C.text = Cs;
            D.text = Ds;
        }
        if (shakeskem == 3)
        {
            whichtrue = 3;
            A.text = Cs;
            B.text = Bs;
            C.text = As ;
            D.text = Ds;
        }
        if (shakeskem == 4)
        {
            whichtrue = 4;
            A.text = Ds;
            B.text = Bs;
            C.text = Cs;
            D.text = As;
        }

    }

}


