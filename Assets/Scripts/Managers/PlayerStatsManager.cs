using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    public static PlayerStatsManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = new PlayerStatsManager();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }
}

