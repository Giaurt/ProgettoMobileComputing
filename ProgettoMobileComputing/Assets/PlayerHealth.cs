using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int maxHealth;
    public int currentHealth;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        currentHealth= maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth<=0){
            isDead = true;
            //gameObject.SetActive(false);
        }
    }
    public void TakeDamage(int damage){
        currentHealth -= damage;
    }
}
