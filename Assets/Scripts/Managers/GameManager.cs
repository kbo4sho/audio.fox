using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public float startCordinates;
    public int endCordinates;
    private int level = 1;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        InitGame();
    }

    private void InitGame()
    {
        LevelManager.instance.InitLevel(level);
    }
}
