using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRoom : MonoBehaviour
{
    public GameObject[] roomPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<UnlockDoor>().hasKey){
            
        }
        
    }
    public void Generate(){
        Transform spawn = gameObject.transform.GetChild(0).transform;
        Instantiate(roomPrefab[Random.Range(0 ,roomPrefab.Length)], spawn.position, Quaternion.identity);
    }
}
