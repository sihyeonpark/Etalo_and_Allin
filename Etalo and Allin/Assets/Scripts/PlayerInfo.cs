﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo PI;

    public int mySelectedCharacter;

    public GameObject[] allCharacters;

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        if(PlayerInfo.PI == null)
        {
            PlayerInfo.PI = this;
        }
        else
        {
            if(PlayerInfo.PI != this)
            {
                Destroy(PlayerInfo.PI.gameObject);
                PlayerInfo.PI = this;
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerInfo_Start");
        if (PlayerPrefs.HasKey("MyCharacter"))
        {
            mySelectedCharacter = PlayerPrefs.GetInt("MyCharacter");
        }
        else
        {
            mySelectedCharacter = 0;
            PlayerPrefs.SetInt("MyCharacter", mySelectedCharacter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
