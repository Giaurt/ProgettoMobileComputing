using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKey : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keyPrefab;
    public Transform spawnPos1;
    public Transform spawnPos2;
    bool canSpawn = true;
    
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(canSpawn && GetComponent<SpawnEnemies>().enemiesNumber==0){
            GameObject key = Instantiate(keyPrefab, new Vector3(Random.Range(spawnPos1.position.x, spawnPos2.position.x), 0.4f, Random.Range(spawnPos1.position.z, spawnPos2.position.z)), Quaternion.identity);
            key.transform.SetParent(gameObject.transform);
            canSpawn = false;
        }
    }
}
