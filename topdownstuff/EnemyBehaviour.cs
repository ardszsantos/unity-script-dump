using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    EntityStats entity_stats;

    public float move_speed;

    GameObject player_object;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();

        player_object = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer() 
    {
        transform.position = Vector3.MoveTowards(transform.position, player_object.transform.position, move_speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            collision.gameObject.GetComponent<EntityStats>().hp -= entity_stats.attack_damage;
            entity_stats.hp -= entity_stats.max_hp + 1; 
            
        }   
    }
}
