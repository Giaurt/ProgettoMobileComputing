using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPos1;
    public Transform spawnPos2;
    public int rndMin;
    public int rndMax;
    public int enemiesNumber;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(){
        enemiesNumber = Random.Range(rndMin, rndMax);
        for(int i = 0; i<enemiesNumber; i++ ){
            Vector3 spawnPosition = new Vector3(Random.Range(spawnPos1.position.x, spawnPos2.position.x), 0, Random.Range(spawnPos1.position.z, spawnPos2.position.z));
            Vector3 rndAngle = new Vector3(0, Random.Range(0, 360), 0);
            GameObject skelly = Instantiate(enemyPrefab, spawnPosition, Quaternion.Euler(rndAngle));
            skelly.transform.SetParent(gameObject.transform);
            
        }
    }

    public void EnemyKilled(){
        enemiesNumber -= 1;
    }
}
