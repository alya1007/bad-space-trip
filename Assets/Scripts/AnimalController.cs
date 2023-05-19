using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public GameObject player;

    public float moveSpeed = 6f;
    public float followRange = 15f;
    public float attackRange = 3f;

    public Vector3 spawnPoint = new Vector3(-14.76f, -2.64f, 0);

    private Rigidbody2D animalRigidBody;
    
    void Start()
    {
        animalRigidBody = GetComponent<Rigidbody2D>();
        transform.position = spawnPoint;   
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= followRange)
        {
            FollowPlayer();

            if (distanceToPlayer <= attackRange)
            {
                Attack();
            }
        }
    }

    void FollowPlayer()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        // transform.localScale = new Vector3(-1, 1, 0);
        GetComponent<SpriteRenderer>().flipX = true;
        animalRigidBody.velocity = direction * moveSpeed;
    }

    void Attack()
    {
        // Implement attack logic
        // ...
    }
}
