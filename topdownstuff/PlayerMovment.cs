using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    EntityStats entity_stats;
    float move_speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();

        move_speed = entity_stats.base_speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        WASDMove();
    }

    void WASDMove()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontal * move_speed * Time.deltaTime, vertical * move_speed * Time.deltaTime));

        if ((horizontal > 0 || horizontal < 0) && (vertical > 0 || vertical < 0))
        {
            move_speed = entity_stats.base_speed * 0.66f;
        } else
        {
            move_speed = entity_stats.base_speed;
        }


    }
}
