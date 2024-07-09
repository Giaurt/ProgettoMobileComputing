using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public float damage = 50;
    
    private void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Enemy")){
            collider.GetComponent<Health>().Damage(damage);
            
        }
    }   
}
