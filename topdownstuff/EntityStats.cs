using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public float max_hp;
    public float hp;
    public float base_speed;
    public float attack_damage;
    public float attack_speed;


    

    public void Start() 
    {
        hp = max_hp;
    }


    public void Update()
    {
        Death();
    }


    void Death() {
        if (hp <= 0) {
            Destroy(this.gameObject);
        }
    }
}

