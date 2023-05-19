using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public GameObject player;
    public PlayerController pc;

    public float moveSpeed = 6f;
    public float followRange = 15f;
    public float attackRange = 6f;

    public Vector3 spawnPoint = new Vector3(-14.76f, -2.64f, 0);

    private Rigidbody2D animalRigidBody;
    
    void Start()
    {
        pc = new PlayerController();
        animalRigidBody = GetComponent<Rigidbody2D>();
        transform.position = spawnPoint;   
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        PlayerController pc = FindObjectOfType<PlayerController>();

        if (distanceToPlayer <= followRange)
        {
            FollowPlayer();
            
            if (distanceToPlayer <= attackRange)
            {
                Attack(pc);
            }
        }
    }

    void FollowPlayer()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        GetComponent<SpriteRenderer>().flipX = true;
        animalRigidBody.velocity = direction * moveSpeed;
    }

    void Attack(PlayerController pc)
    {
        int damage = Random.Range(30, 50);
        pc.decreaseHealth(damage);
    }
}
