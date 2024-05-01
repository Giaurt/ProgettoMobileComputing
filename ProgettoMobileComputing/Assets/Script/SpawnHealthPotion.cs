using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealthPotion : MonoBehaviour
{
    public GameObject potionPrefab;
    public Transform spawnPos1;
    public Transform spawnPos2;
    bool canSpawn = true;
    public int rnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn && GetComponent<SpawnEnemies>().enemiesNumber==0){
            rnd = Random.Range(0,100);
            if(Random.value >0.7){
                GameObject key = Instantiate(potionPrefab, new Vector3(Random.Range(spawnPos1.position.x, spawnPos2.position.x), spawnPos1.position.y, Random.Range(spawnPos1.position.z, spawnPos2.position.z)), Quaternion.Euler(0f, 0f, 0f));
                key.transform.SetParent(gameObject.transform);
                
            }
            canSpawn = false;
            
        }
    }
}
