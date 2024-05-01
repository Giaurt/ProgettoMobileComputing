using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject attackArea = default;
    bool attacking = false;
    public float timeToAttack;
    public float rate = 2.5f;
    private float timer = 0f;
    public Animator animator;

    bool canAttack = true;
    public bool isAttacking = false;
    bool isInRange;
    EnemyFollow enemyFollow;

    bool isDead;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyFollow = GetComponent<EnemyFollow>();
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        isDead = GetComponent<Health>().isDead;
        animator.SetBool("IsInRange", enemyFollow.canAttackRange);
        
       if(canAttack && enemyFollow.canAttackRange && !isDead){
            
            isAttacking = true;
            StartCoroutine(AttackTimer());
        }
        

        if(attacking){
            timer += Time.deltaTime;
            if(timer >= timeToAttack){
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
                
            }
        }

    }

    

    public void Attack(){
        attacking = true;
        attackArea.SetActive(attacking);
        
        
        
    }

    IEnumerator AttackTimer(){
        canAttack = false;
        Attack();
        yield return new WaitForSeconds(rate);
        canAttack = true;
        isAttacking = false;

    }
    
}
