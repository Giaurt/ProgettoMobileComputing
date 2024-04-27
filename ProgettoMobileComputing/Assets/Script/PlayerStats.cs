using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int enemyKilled;
    public static int rooms;

    public TMP_Text skeletonKilled;
    public TMP_Text roomSurvived;
    // Start is called before the first frame update
    void Start()
    {
        skeletonKilled.text = PlayerPrefs.GetInt("MaxSkeletonKilled").ToString();
        roomSurvived.text = PlayerPrefs.GetInt("MaxRoomSurvived").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
