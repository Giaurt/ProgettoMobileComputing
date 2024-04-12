using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public float damage;
    
    private void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Enemy")){
            Debug.Log("entra");
            collider.GetComponent<Health>().Damage(damage);
            
        }
    }
}
