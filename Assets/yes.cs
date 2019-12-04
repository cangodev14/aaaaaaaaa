using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
       
        
            if (generator.questpoporyad == 1)
            {
                score.schet = 0;
            }
            if (generator.questpoporyad == 2)
            {
                score.schet = 500;
            }
            if (generator.questpoporyad == 3)
            {
                score.schet = 1000;
            }
            if (generator.questpoporyad == 4)
            {
                score.schet = 2000;
            }
            if (generator.questpoporyad == 5)
            {
                score.schet = 3000;
            }
            if (generator.questpoporyad == 6)
            {
                score.schet = 5000;
            }
            if (generator.questpoporyad == 7)
            {
                score.schet = 10000;
            }
            if (generator.questpoporyad == 8)
            {
                score.schet = 15000;
            }
            if (generator.questpoporyad == 9)
            {
                score.schet = 25000;
            }
            if (generator.questpoporyad == 10)
            {
                score.schet = 50000;
            }
            if (generator.questpoporyad == 11)
            {
                score.schet = 100000;
            }
            if (generator.questpoporyad == 12)
            {
                score.schet = 200000;
            }
            if (generator.questpoporyad == 13)
            {
                score.schet = 400000;
            }
            if (generator.questpoporyad == 14)
            {
                score.schet = 800000;
            }
            if (generator.questpoporyad == 15)
            {
                score.schet = 1500000;
            }
        
        zabratmoney.alr = false;
        generator.podskazused = false;
        if (start.SSEC == true)
        {
            SceneManager.LoadScene("schet", LoadSceneMode.Single);
        }
        else
        SceneManager.LoadScene("schet", LoadSceneMode.Single);
        PlayerPrefs.SetInt("score",PlayerPrefs.GetInt("score")+score.schet);
    }
}
