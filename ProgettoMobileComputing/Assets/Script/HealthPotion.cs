using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int healValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            FindAnyObjectByType<AudioManager>().Play("DrinkPotion");
            collider.gameObject.GetComponent<PlayerHealth>().Heal(healValue);
            Destroy(gameObject);
        }
    }
}
