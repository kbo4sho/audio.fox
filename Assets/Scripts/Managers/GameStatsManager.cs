using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatsManager : MonoBehaviour
{

    public static GameStatsManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = new GameStatsManager();
        } else if (instance != this) {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }
}

