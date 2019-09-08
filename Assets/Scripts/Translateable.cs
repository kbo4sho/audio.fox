using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translateable : MonoBehaviour
{
    public float delayStart;
    public bool started; 
    public bool ended;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ended)
        {
            _timer += Time.deltaTime;
            CheckIfStarted();
            if (started)
            {
                transform.position = new Vector3(transform.position.x - (transform.position.x == 0 ? _timer - delayStart : Time.deltaTime), transform.position.y);
            }
            CheckIfEnded();
        }
    }

    private void CheckIfEnded()
    {
        if (this.gameObject.transform.localPosition.x < GameManager.instance.endCordinates)
        {
            ended = true;
        }
    }

    private void CheckIfStarted()
    {
        if (!started)
        {
            if (_timer > delayStart)
            {            
                started = true;
            }
        }
    }
}
