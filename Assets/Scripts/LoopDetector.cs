using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDetector : MonoBehaviour
{
    private Translateable[] _children;
    public Rigidbody playerRigidBody;

    void Start()
    {
        _children = this.GetComponentsInChildren<Translateable>();
    }

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
                    LevelManager.instance.CallAction(new Loop());
                }
            }
        }

    }
}

