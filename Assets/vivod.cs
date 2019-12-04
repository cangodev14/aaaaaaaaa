using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vivod : MonoBehaviour
{
    public static float cntbbb=46;
    public TextMesh sam;
    public static float mezdu=0;
    public GameObject prefabplis;
    public static float schet=0;
    public GameObject polosa;
    // Start is called before the first frame update
    void Start()
    {
        cntbbb = 46;
        mezdu = 0;
        score.schet = 0;
        sam.text = "0";
    }
    void Awake()
    {
          cntbbb = 46;
        mezdu = 0;
        score.schet = 0;
        sam.text = "0";
        schet = 0;
    }
    // Update is called once per frame
    void Update()
    {
        polosa.transform.localScale = new Vector2(cntbbb/2.6f,0.34f);
        if (cntbbb < 0)
        {
            zabratmoney.alr = false;
            generator.podskazused = false;
            if (start.SSEC == true)
            {
                SceneManager.LoadScene("schet", LoadSceneMode.Single);
                start.SSEC = false;
            }
            else
                SceneManager.LoadScene("schet", LoadSceneMode.Single);
            {
                PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + score.schet);
            }

        }
        score.schet = Mathf.RoundToInt(schet);
        sam.text = score.schet.ToString();
        if(plus15sec.hah==false)
        cntbbb -= Time.deltaTime/2; 
        if (gameObject.name == "ddd")
        {
            gameObject.GetComponent<TextMesh>().text = schet.ToString("0");
        }
        if (gameObject.name != "ddd")
            sam.text = cntbbb.ToString("0");
        if (onclick.shitat == true)
        {
            mezdu += Time.deltaTime;
        }
        if (onclick.shitat2 == true)
        {
            
            onclick.shitat2 = false;
            onclick.shitat = true;
            schet = schet + (100 / mezdu)*(100/mezdu)*11* (100 / mezdu);
            GameObject lol = Instantiate(prefabplis);
            score.schet = Mathf.RoundToInt(schet);
            lol.GetComponent<TextMesh>().text = "+" + ((100 / mezdu) *11* (100 / mezdu) * (100 / mezdu)).ToString("0");
            mezdu = 0;
           
            
        }
    }
}
