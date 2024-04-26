using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Animator animator;
    public float health = 100f;
    public float currentHealth;
    bool isDead = false;
    ScoreManager scoreManager;
    void Start()
    {
        currentHealth = health;
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth<=0 && !isDead){
            animator.Play("Death");
            transform.parent.GetComponent<SpawnEnemies>().EnemyKilled();
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<CapsuleCollider>().enabled = false;
            scoreManager.EnemyKilled();
        }
        if(currentHealth == 0){
            isDead = true;
        }
    }

    public void Damage(float damage){
        if(!isDead){
            animator.Play("TakeDamage");
            currentHealth = currentHealth - damage;
        }
        
    }
}
