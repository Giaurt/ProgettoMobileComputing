using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int enemyKilled = 0;
    int roomSurvived = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey("MaxSkeletonKilled") && PlayerPrefs.GetInt("MaxSkeletonKille")<enemyKilled){
            PlayerPrefs.SetInt("MaxSkeletonKilled", enemyKilled);
        }else{
            PlayerPrefs.SetInt("MaxSkeletonKilled", enemyKilled);
        }
        if(PlayerPrefs.HasKey("MaxRoomSurvived") && PlayerPrefs.GetInt("MaxRoomSurvived")<roomSurvived){
            PlayerPrefs.SetInt("MaxRoomSurvivewd", roomSurvived);
        }else{
            PlayerPrefs.SetInt("MaxRoomSurvived", roomSurvived);
        }
    }
    public void EnemyKilled(){
        enemyKilled++;
    }
    public void Survived(){
        roomSurvived++;
    }
}
