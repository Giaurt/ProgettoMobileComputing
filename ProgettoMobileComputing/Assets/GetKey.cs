using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            GetComponentInParent<UnlockDoor>().OpenDoor();
            GetComponentInParent<GenerateRoom>().Generate();
            Destroy(gameObject);
            
        }
    }
    
}
