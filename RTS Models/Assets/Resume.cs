using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{

    public Transform Background;
    public Transform Menu;

    //Update is called once per frame

    void Update()
    {

        
    }


    public void Pause()
    {






        if (Menu.gameObject.activeInHierarchy)
        {
            Menu.gameObject.SetActive(false);

        }
        else
        {

            Menu.gameObject.SetActive(true);
        }



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
