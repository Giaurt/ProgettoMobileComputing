using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject door;

    public bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor(){
        
        door.transform.Rotate(0, -90, 0);
        door.transform.position = new Vector3(door.transform.position.x+1, door.transform.position.y, door.transform.position.z+1);
    }
}
