using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPointGeneratorChild : MonoBehaviour
{
    public float delayStart;
    public bool started;
    public bool ended;

    public void CheckIfEnded()
    {
        if(this.gameObject.transform.position.x < GameManager.instance.endCordinates)
        {
            ended = true;
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
