using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    // private int level = 1;

    private void Awake()
    {
        if(instance == null)
        {

        }else if (instance != this)
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
            InitGame();
        }
    }

    private void InitGame()
    {
        // Setup level
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
