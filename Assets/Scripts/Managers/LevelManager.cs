using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance = null;
    private int level = 1;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

        } else if (instance != this) {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }

    public void InitLevel(int level)
    {
        // Setup level
        Debug.Log("Start Level" + level);
    }

    public void CallAction(IAction action )
    {   
        if(action is Loop)
        {
            Debug.Log("Loop");
        }else if(action is LevelComplete)
        {
            Debug.Log("Level Complete");
        }
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
