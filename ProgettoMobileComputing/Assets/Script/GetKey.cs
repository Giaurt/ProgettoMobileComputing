using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    GameObject closedDoor;
    GameObject openDoor;
    // Start is called before the first frame update
    void Start()
    {
        closedDoor = transform.parent.GetChild(1).gameObject;
        //openDoor = transform.parent.GetChild(2).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            FindAnyObjectByType<AudioManager>().Play("UnlockDoor");
            GetComponentInParent<UnlockDoor>().OpenDoor();
            GameObject.FindGameObjectWithTag("RoomSpawner").GetComponent<RoomSpawner>().SpawnRoom();
            Destroy(gameObject);
            closedDoor.SetActive(true);

            
        }
    }
    
}
