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

    
    // Start is called before the first frame update
    void Start()
    {
        enemyFollow = GetComponent<EnemyFollow>();
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("IsInRange", enemyFollow.canAttackRange);
        /*if(Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }*/
        /*if(canAttack && Input.GetMouseButtonDown(0)){
            isAttacking = true;
            StartCoroutine(AttackTimer());

        }*/
       if(canAttack && enemyFollow.canAttackRange){
            Debug.Log("entra");
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

    /*public void AttackButton(){
        if(canAttack){
            Debug.Log("entraAtta");
            isAttacking = true;
            StartCoroutine(AttackTimer());
        }
    }*/

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
    /*void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            isInRange = true;
        } 
    }
    void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            isInRange = false;
            Debug.Log("uscito");
        } 
    }*/
}
