using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    Animator anim;

    float timer = 1f;

    float timeBetweenBullets = 1f;

    float effectsDisplayTime = 0.2f;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButton("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
        {

            timer = 0f;
            anim.SetTrigger("Attack");

        }

        if (timer >= timeBetweenBullets * effectsDisplayTime)
        {
            DisableEffects();
        }
    }


    public void DisableEffects()
    {

    }














}
