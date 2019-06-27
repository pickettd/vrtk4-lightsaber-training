﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactors;

public class AutoGrabSaber : MonoBehaviour
{
    public GameObject saberToGrab;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<InteractorFacade>().Grab(saberToGrab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}