using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public Animator cam;
    private int whatcam = 0;
    public static float counter = 4;
    public GameObject front;
    public  GameObject prof;

    // Start is called before the first frame update
    void Start()
    {
        counter = 4;
    }
   
    // Update is called once per frame
    void Update()
    {
  
       // Debug.Log(counter);
       if (counter>100)

        {
            {
                if (generator.questpoporyad > 5) { 
               // front.SetActive(false);
              // prof.SetActive(true);
              }
            }
            
        }
        counter -= Time.deltaTime;
        if (counter < 0)
        {
            if (whatcam == 0)
            {
                //defaultview
                cam.Play("osnova");
                counter = Random.Range(3f, 10f);
                whatcam = 1;
            }
            else
            {
                changecam();
            }
        }
    }
    void changecam()
    {
        whatcam = Random.Range(1, 7);
        if (whatcam == 2 || whatcam == 6)
        {
            if (generator.questpoporyad < 12)
            {
                if (start.SSEC == false)
                {
                    counter = Random.Range(6f, 11f);
                    cam.Play("frontved");
                    front.SetActive(true);
                    prof.SetActive(false);
                    front.GetComponent<repliccontrol>().ChooseRep();
                }
            }
        }
        if (whatcam == 3)
        {
            if (start.SSEC == false)
            {
                counter = Random.Range(7f, 17f);
                cam.Play("frontcont");
                front.SetActive(false);
                prof.SetActive(true);
            }
        }
        if (whatcam == 4)
        {
            if (start.SSEC == false)
            {
                counter = Random.Range(12f, 19f);
                cam.Play("sugla");
                front.SetActive(false);
                prof.SetActive(true);
            }
        }
        if (whatcam == 5)
        {
            if (start.SSEC == false)
            {
                counter = Random.Range(16f, 18f);
                cam.Play("2sugla");
                front.SetActive(false);
                prof.SetActive(true);
            }
        }
        if (whatcam == 1)
        {
            if (start.SSEC == false)
            {
                counter = Random.Range(7f, 21f);
                cam.Play("osnova");
                front.SetActive(false);
                prof.SetActive(true);
            }
        }
    }
}
