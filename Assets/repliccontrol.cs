using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repliccontrol : MonoBehaviour
{
    public GameObject vnsk;
    public TextAsset file;
    public TextAsset fileeng;
    private int numbers=86;
    public static bool used50=false;
    private string[] numberQuest1;
   
    public TextMesh samtxt;
    private int randik;
    public static int r;
    // Start is called before the first frame update
    void Start()
    {
        used50 = false;
        if (PlayerPrefs.GetInt("lang") == 1)
            numberQuest1 = fileeng.text.Split('\r');
        else
            numberQuest1 = file.text.Split('\r');
        
       // r = Random.Range(1,6);
        //if (r > 2)
       // {
        //    vnsk.SetActive(true);
          ChooseRep();
       //
       // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseRep()
    {

        if (generator.questpoporyad == 15)
            if (PlayerPrefs.GetInt("lang") == 1)
                samtxt.text = "Here it is, the final answer";
        else
        samtxt.text = "И вот он, финальный ответ...";
        else
        {
            if (generator.questpoporyad == 12 | generator.questpoporyad == 13 | generator.questpoporyad == 14&onclick.already==true)
            {
                r = Random.Range(0, 3);
                {
                    if (r == 0)
                        if (PlayerPrefs.GetInt("lang") == 1)
                            samtxt.text = "You didn't have to do it quick";
                        else
                        samtxt.text = "Не надо было торопиться...";
                    if (r == 1)
                        if (PlayerPrefs.GetInt("lang") == 1)
                            samtxt.text = "The answer was so close, and..";
                        else
                        samtxt.text = "Ответ был так близок, и..";
                    if (r == 2)
                        if (PlayerPrefs.GetInt("lang") == 1)
                            samtxt.text = "Well, let's take a look..";
                        else
                        samtxt.text = "Ну что же, посмотрим...";
                }
            }
            else
            {
                if (generator.questpoporyad < 6)
                {
                    randik = Random.Range(0, 35);
                }
                else
                if (generator.questpoporyad < 16 & generator.questpoporyad > 5)
                {
                    if (used50 == false)
                        randik = Random.Range(35, 84);
                    else
                        randik = Random.Range(35, 67);
                }
                samtxt.text = numberQuest1[randik].ToString();
            }
        }
    }
    
}
