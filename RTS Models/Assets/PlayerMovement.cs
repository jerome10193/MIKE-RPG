using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 6f;

    Vector3 movement;
    float Chargetimer=5f;
    float TimeBetweenCharge = 5f;
    float TimeInCharge = 1f;

    Animator anim;

    Rigidbody PlayerRigidbody;

    Transform PlayerTransform;


    public Vector3 eulerAngleVelocity = new Vector3(0, 0, 0);

    bool jump = false;
    bool jumpHeight = true;

    void Update()
    {


        Chargetimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.F) && Chargetimer >= TimeBetweenCharge && Time.timeScale != 0) 
        {
            Chargetimer = 0.0f;

            speed = 20;

           // anim.SetBool("IsCharging", true);

        }

        if (TimeInCharge < Chargetimer && Time.timeScale != 0)
        {
            speed = 6f;
            //anim.SetBool("IsCharging", false);
        }





    }



    void Awake()

    {
 
        anim = GetComponent<Animator>();
        PlayerRigidbody = GetComponent<Rigidbody>();
        PlayerTransform = GetComponent<Transform>();

    }




    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
     





        Move(h, v);

            Turning();

  

        Animating(h, v);


    }

    void Move(float h ,float v)

    {


        if(v>0) {
            Vector3 MoveVector = Camera.main.transform.forward;
            MoveVector.y = 0;
            MoveVector = MoveVector * speed * Time.deltaTime;
            PlayerRigidbody.MovePosition (transform.position + MoveVector);

        }


        if (v < 0)
        {
            Vector3 MoveVector = Camera.main.transform.forward;
            MoveVector.y = 0;
            MoveVector = MoveVector * -speed * Time.deltaTime;
            PlayerRigidbody.MovePosition(transform.position + MoveVector);

        }


        if (v == 0)
        {
            //Vector3 MoveVector = Camera.main.transform.forward;
           //MoveVector.y = 0;
            //PlayerRigidbody.velocity = MoveVector * 0;

        }



        /*
        movement.Set(h, 0f, v);

        movement = movement.normalized * speed * Time.deltaTime;

        movement = Camera.main.transform.TransformDirection(movement);

        PlayerRigidbody.MovePosition(transform.position + movement);
        */

    }






    void Turning()

   {


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
       {
            //transform.Rotate(Vector3.right * Time.deltaTime);

            transform.Rotate(0, Time.deltaTime * -150, 0);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate(Vector3.right * Time.deltaTime);

            transform.Rotate(0, Time.deltaTime * 150, 0);

        }


        // if (Input.GetButtonDown("RotateCharacter"))
        // {


        //     Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);



        //     PlayerRigidbody.MoveRotation(PlayerRigidbody.rotation * deltaRotation);



        //   }




    }


    void Animating(float h, float v)
    {

        bool walking = h != 0f || v != 0f;
        anim.SetBool("IsWalking", walking);
    }






















}
