using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float maxDistance;
    public float minDistance;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(TargetDistance()<maxDistance && TargetDistance()>minDistance){
            transform.position = Vector3.MoveTowards(transform.position, player.position, 2 * Time.deltaTime);
            //transform.rotation = new Quaternion(0, GetAngleBetweenTarget().y, 0, 0);
            transform.LookAt(player.transform);
        }
        
    }

    Quaternion GetAngleBetweenTarget(){
        Vector3 targetDir = player.transform.position - transform.position;
        Quaternion lookDir = Quaternion.LookRotation(targetDir);
        return lookDir;
    }
    float TargetDistance(){
        float distance = Vector3.Distance(player.transform.position, transform.position);


        return distance;
    }
}
