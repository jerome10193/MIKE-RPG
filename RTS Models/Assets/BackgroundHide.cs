using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundHide : MonoBehaviour
{

    public Transform Background;

    //Update is called once per frame

    void Update()
    {

        if (Background)
        {

            Pause();
        }
    }


    public void Pause()
    {




            if (Input.GetKeyDown(KeyCode.Escape))
            {

                if (Background.gameObject.activeInHierarchy)
                {
                    Background.gameObject.SetActive(false);
                    Time.timeScale = 1;

                }
                else
                {

                    Background.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }


            

        }

    }






    }
