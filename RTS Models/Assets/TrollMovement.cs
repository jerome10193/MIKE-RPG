using UnityEngine;
using System.Collections;

public class TrollMovement : MonoBehaviour
{
    Transform player;
    // PlayerHealth playerHealth;
    // EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    Animation anim;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        // enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animation>();
    }


    void Update()
    {
        // if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        // {
        nav.SetDestination(player.position);

        anim.Play();


        // }
        // else
        //{
        //    nav.enabled = false;
        // }
    }
}