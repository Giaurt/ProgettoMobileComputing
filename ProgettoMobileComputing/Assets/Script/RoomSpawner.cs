using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public GameObject[] rooms;
    public GameObject firstSpawnPoint;
    public GameObject temp;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnPoint = firstSpawnPoint.transform.position;
        /*for(int i = 0; i<2; i++){
            SpawnTile();
        }*/
    }

    public void SpawnRoom(){
        int rnd = Random.Range(0,rooms.Length);
        temp = Instantiate(rooms[rnd], nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(0).transform.position;
    }
}
