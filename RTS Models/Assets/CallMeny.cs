using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMeny : MonoBehaviour
{

    public Transform canvas;

    //Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if(canvas.gameObject.activeInHierarchy)
            {
                canvas.gameObject.SetActive(false);

            }else
            {

                canvas.gameObject.SetActive(true);
            }


        }

    }




}

