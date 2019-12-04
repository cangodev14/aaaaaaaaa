using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ebal
{
    public class fiftytip : MonoBehaviour
    {
        public GameObject A;
        public GameObject B;
        public GameObject C;
        public GameObject D;
        public AudioSource tudin;
        private int random;
        private bool used = false;

        // Use this for initialization
        void Start()
        {
            used = false;

        }

        // Update is called once per frame
        void Update()
        {

            if (onclick.dlya50 == true & used == true)
            {
                A.SetActive(true);
                B.SetActive(true);
                C.SetActive(true);
                D.SetActive(true);

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
                        Debug.Log(generator.whichtrue);
                        tudin.Play();
                        gameObject.GetComponent<Animator>().Play("ubiv");
                        gameObject.GetComponent<CircleCollider2D>().enabled = false;

                        if (generator.whichtrue == 1)
                        {
                            A.gameObject.SetActive(true);
                            random = Random.Range(1, 4);
                            if (random == 1)
                            {
                                C.gameObject.SetActive(false);
                                D.gameObject.SetActive(false);
                                B.gameObject.SetActive(true);
                            }
                            else if (random == 2)
                            {
                                B.gameObject.SetActive(false);
                                D.gameObject.SetActive(false);
                                C.gameObject.SetActive(true);
                            }
                            else if (random == 3)
                            {
                                B.gameObject.SetActive(false);
                                C.gameObject.SetActive(false);
                                D.gameObject.SetActive(true);
                            }
                        }
                        if (generator.whichtrue == 2)
                        {
                            B.gameObject.SetActive(true);
                            random = Random.Range(1, 4);
                            if (random == 1)
                            {
                                C.gameObject.SetActive(false);
                                D.gameObject.SetActive(false);
                                A.gameObject.SetActive(true);
                            }
                            else
                            if (random == 2)
                            {
                                C.gameObject.SetActive(true);
                                D.gameObject.SetActive(false);
                                A.gameObject.SetActive(false);
                            }
                            else
                            if (random == 3)
                            {
                                C.gameObject.SetActive(false);
                                D.gameObject.SetActive(true);
                                A.gameObject.SetActive(false);
                            }
                        }
                        if (generator.whichtrue == 3)
                        {
                            C.gameObject.SetActive(true);
                            random = Random.Range(1, 4);
                            if (random == 1)
                            {
                                B.gameObject.SetActive(false);
                                D.gameObject.SetActive(false);
                                A.gameObject.SetActive(true);
                            }
                            else if (random == 2)
                            {
                                B.gameObject.SetActive(true);
                                D.gameObject.SetActive(false);
                                A.gameObject.SetActive(false);
                            }
                            else if (random == 3)
                            {
                                B.gameObject.SetActive(false);
                                D.gameObject.SetActive(true);
                                A.gameObject.SetActive(false);
                            }
                        }
                        if (generator.whichtrue == 4)
                        {
                            D.SetActive(true);
                            random = Random.Range(1, 4);
                            if (random == 1)
                            {
                                B.gameObject.SetActive(true);
                                C.gameObject.SetActive(false);
                                A.gameObject.SetActive(false);
                            }
                            else if (random == 2)
                            {
                                A.gameObject.SetActive(false);
                                C.gameObject.SetActive(true);
                                B.gameObject.SetActive(false);
                            }
                            else if (random == 3)
                            {
                                A.gameObject.SetActive(true);
                                B.gameObject.SetActive(false);
                                C.gameObject.SetActive(false);
                            }
                        }
                        used = true;

                    }
                }
            }
        }
    }
}
