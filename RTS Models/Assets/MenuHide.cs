using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHide : MonoBehaviour
{

    public Transform Menu;

    //Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (Menu.gameObject.activeInHierarchy)
            {
                Menu.gameObject.SetActive(false);

            }
            else
            {

                Menu.gameObject.SetActive(true);
            }


        }

    }




}
