using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using tm_vr.controllables.levers;

public class Controllable_SendingManager : MonoBehaviour {
    public int index = 0;
    public int indexCount = 0;
    public Controllable_Sender[] senders;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Switch()
    {
        index++;
        if(index > indexCount - 1)
        {
            index = 0;
        }
        
        foreach(Controllable_Sender sends in senders)
        {
            sends.currindx = index;
        }
    }
}
