﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;
using VRTK.Examples;
using tm_vr.controllables.levers;

public class Controllable_ExitBut : MonoBehaviour {
    ControllableReactor controlreactor;
    // Use this for initialization
    void Start () {
        controlreactor = GetComponent<ControllableReactor>();
    }
	
	// Update is called once per frame
	void Update () {
        if (controlreactor.isPressed && !controlreactor.pushSent)
        {
            Application.Quit();
            controlreactor.pushSent = true;
        }
    }
}
