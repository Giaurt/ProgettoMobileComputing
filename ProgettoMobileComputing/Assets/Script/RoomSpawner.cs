using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    GameObject startingRoom;
    public List<GameObject> spawnedRooms;
    public GameObject[] rooms;
    public GameObject firstSpawnPoint;
    public GameObject temp;
    Vector3 nextSpawnPoint;
    int currentRoomIndex = 0;
    int destroyIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnPoint = firstSpawnPoint.transform.position;
        startingRoom = GameObject.FindGameObjectWithTag("StartingRoom");
        spawnedRooms.Add(startingRoom);

    }
    void Update(){
        if(currentRoomIndex == 2){
            currentRoomIndex--;
            Destroy(spawnedRooms[destroyIndex]);
            destroyIndex++;
        }
    }

    public void SpawnRoom(){
        int rnd = Random.Range(0,rooms.Length);
        spawnedRooms.Add(Instantiate(rooms[rnd], nextSpawnPoint, Quaternion.identity));
        currentRoomIndex++;
        nextSpawnPoint = spawnedRooms.LastOrDefault().transform.GetChild(0).transform.position;
    }
    
}
