﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBasic : MonoBehaviour, IStage{

    public Translateable[] Childs => GetComponentsInChildren<Translateable>(true);

    public bool CanAdvance => true;

    // Start is called before the first frame update
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {

    }
}