using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int enemyKilled = 0;
    public int roomSurvived = 0;
    public TMP_Text gameOverRooms;
    public TMP_Text pauseRooms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.HasKey("MaxSkeletonKilled")){
            if(PlayerPrefs.GetInt("MaxSkeletonKilled")<enemyKilled){
                PlayerPrefs.SetInt("MaxSkeletonKilled", enemyKilled);
            }
        }else{
            PlayerPrefs.SetInt("MaxSkeletonKilled", enemyKilled);
        }
        if(PlayerPrefs.HasKey("MaxRoomSurvived")){
            if(PlayerPrefs.GetInt("MaxRoomSurvived")<roomSurvived){
                PlayerPrefs.SetInt("MaxRoomSurvived", roomSurvived);
            }
        }else{
            PlayerPrefs.SetInt("MaxRoomSurvived", roomSurvived);
        }
        gameOverRooms.text = roomSurvived.ToString();
        pauseRooms.text = roomSurvived.ToString();
    }
    public void EnemyKilled(){
        enemyKilled++;
    }
    public void Survived(){
        roomSurvived++;
    }
}
