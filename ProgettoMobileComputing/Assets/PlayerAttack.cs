using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    public GameObject attackArea = default;
    bool attacking = false;
    public float timeToAttack;
    public float rate = 2.5f;
    private float timer = 0f;
    public Animator animator;

    bool canAttack = true;

    
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }*/
        if(canAttack && Input.GetMouseButtonDown(0)){
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
        //animator.SetBool("Attack1", attacking);
        
    }

    IEnumerator AttackTimer(){
        canAttack = false;
        Attack();
        yield return new WaitForSeconds(rate);
        canAttack = true;

    }
}
