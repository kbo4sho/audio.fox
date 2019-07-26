using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDetector : MonoBehaviour
{
    private HookPointGeneratorChild[] _children;
    public Rigidbody playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _children = this.GetComponentsInChildren<HookPointGeneratorChild>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var child in _children)
        {
            if (child.started)
            {
                var isAbove = playerRigidBody.transform.position.y > child.transform.position.y;
                var isAligned = Mathf.Round(playerRigidBody.transform.position.x) == Mathf.Round(child.transform.position.x);
                if (isAbove && isAligned)
                {
                    Debug.Log("YAAA");
                }
            }
        }

    }
}

