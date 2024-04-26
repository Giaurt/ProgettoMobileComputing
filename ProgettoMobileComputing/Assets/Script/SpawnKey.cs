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
    ScoreManager scoreManager;
    
    void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if(canSpawn && GetComponent<SpawnEnemies>().enemiesNumber==0){
            GameObject key = Instantiate(keyPrefab, new Vector3(Random.Range(spawnPos1.position.x, spawnPos2.position.x), spawnPos1.position.y, Random.Range(spawnPos1.position.z, spawnPos2.position.z)), Quaternion.Euler(90f, 0f, 0f));
            key.transform.SetParent(gameObject.transform);
            canSpawn = false;
            scoreManager.Survived();
        }
    }
}
