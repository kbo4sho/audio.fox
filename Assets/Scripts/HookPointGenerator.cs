using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPointGenerator : MonoBehaviour
{
    public float startCordinates;
    public float endCordinates;
    // public List<GameObject> hookPoints;
    // WIll look at children in the UI instead, means the delay needs to be configured in the UI as well.
    private HookPointGeneratorChild[] _children;
    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        _children = this.GetComponentsInChildren<HookPointGeneratorChild>();
        Debug.Log(_children);
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        Debug.Log(_timer);

        foreach (var child in _children)
        {
            if (!child.started)
            {
                if(_timer > child.delayStart)
                {
                    child.started = true;
                }
            }else
            {
                child.transform.position = new Vector3(child.transform.position.x - (child.transform.position.x == 0 ? _timer - child.delayStart : Time.deltaTime), child.transform.position.y);
            }
        }
    }
}
