using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public Animator animator;
    public Transform player;
    public float maxDistance;
    public float minDistance;
    public bool isInRange = false;
    bool isTargeted = false;
    public bool canAttackRange = false;
    [SerializeField]
    int damage; 
    bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Health>().currentHealth<=0){
            isDead = true;
        }
        //animator.SetBool("IsInRange", isInRange);
        if(!isDead){
            if(TargetDistance()<maxDistance && !isTargeted){
            animator.SetBool("TargetAcquired", true);
            transform.position = Vector3.MoveTowards(transform.position, player.position, 2 * Time.deltaTime);
            //transform.rotation = new Quaternion(0, GetAngleBetweenTarget().y, 0, 0);
            transform.LookAt(player.transform);
            isTargeted = true;
        }else{
            animator.SetBool("TargetAcquired", false);
        }
        if(isTargeted){
            animator.SetBool("TargetAcquired", true);
            transform.position = Vector3.MoveTowards(transform.position, player.position, 2 * Time.deltaTime);
            //transform.rotation = new Quaternion(0, GetAngleBetweenTarget().y, 0, 0);
            transform.LookAt(player.transform);
            isTargeted = true;
        }
        if(TargetDistance()<=minDistance){
            canAttackRange = true;
        }
        if(TargetDistance()>minDistance){
            canAttackRange = false;
        }
        }
        
    }

    Quaternion GetAngleBetweenTarget(){
        Vector3 targetDir = player.transform.position - transform.position;
        Quaternion lookDir = Quaternion.LookRotation(targetDir);
        return lookDir;
    }
    float TargetDistance(){
        float distance = Vector3.Distance(player.transform.position, transform.position);


        return distance;
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        } 
    }
    void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            canAttackRange = false;
            Debug.Log("uscito");
        } 
    }
}
