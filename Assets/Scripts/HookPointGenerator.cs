using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPointGenerator : MonoBehaviour
{
    
    // public List<GameObject> hookPoints;
    // WIll look at children in the UI instead, means the delay needs to be configured in the UI as well.
    private HookPointGeneratorChild[] _children;
    private float _timer;
    private bool isComplete;
    // Start is called before the first frame update
    void Start()
    {
        _children = this.GetComponentsInChildren<HookPointGeneratorChild>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isComplete)
        {

            _timer += Time.deltaTime;

            foreach (var child in _children)
            {
                if (!child.started)
                {
                    if (_timer > child.delayStart)
                    {
                        child.started = true;
                    }
                }
                else
                {
                    child.transform.position = new Vector3(child.transform.position.x - (child.transform.position.x == 0 ? _timer - child.delayStart : Time.deltaTime), child.transform.position.y);
                }
                child.CheckIfEnded();
            }
            CheckIfComplete();
        }
    }

    private void CheckIfComplete()
    {
        foreach (var child in _children)
        {
            if (!child.ended)
            {
                return;
            }
        }
        isComplete = true;
        LevelManager.instance.CallAction(new EnterFinal());
    }
}
