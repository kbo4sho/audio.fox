using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPointGenerator : MonoBehaviour
{

    // public List<GameObject> hookPoints;
    // WIll look at children in the UI instead, means the delay needs to be configured in the UI as well.
    private IStage[] _stages;
    private HookPointGeneratorChild[] _children;
    private float _timer;
    private bool isComplete;
    private int _activeStageIndex;
    // Start is called before the first frame update
    void Start()
    {
        _stages = this.GetComponentsInChildren<IStage>();
        _activeStageIndex = 0;    

        // Start a stage, activate all in children so they can handle their own delays

        foreach (var stage in _stages)
        {
            Debug.Log(stage.Childs.Length);
        }

        SetStageActive(_activeStageIndex);
    }

    private void SetStageActive(int index)
    {
        foreach (var child in _stages[_activeStageIndex].Childs)
        {
            child.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfComplete();
    }

    private void CheckIfComplete()
    {
        foreach (var child in _stages[_activeStageIndex].Childs)
        {
            if (!child.ended)
            {
                return;
            }
        }
        SetStageActive(_activeStageIndex++);
        // LevelManager.instance.CallAction(new EnterFinal());
        // TODO next stage maybe?
    }
}
