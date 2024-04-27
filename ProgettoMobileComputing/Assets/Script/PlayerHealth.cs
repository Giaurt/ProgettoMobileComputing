using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int maxHealth;
    public int currentHealth;
    public bool isDead;
    public Slider slider;
     
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        currentHealth = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
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
        slider.value = currentHealth;
        
    }
    public void Heal(int heal){
        currentHealth += heal;
        slider.value = currentHealth;
        
    }
}
