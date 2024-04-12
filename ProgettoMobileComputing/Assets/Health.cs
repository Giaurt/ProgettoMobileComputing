using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;
    public float currentHealth;
    void Start()
    {
        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth<=0){
            Destroy(gameObject);
            transform.parent.GetComponent<SpawnEnemies>().EnemyKilled();
        }
    }

    public void Damage(float damage){
        currentHealth = currentHealth - damage;
    }
}
