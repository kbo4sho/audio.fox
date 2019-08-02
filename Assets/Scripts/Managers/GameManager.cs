using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    private int level = 1;

    private void Awake()
    {
        if(instance == null)
        {
            instance = new GameManager();
        }else if (instance != this)
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
        InitGame();
    }

    private void InitGame()
    {
        LevelManager.instance.InitLevel(level);
    }
}
