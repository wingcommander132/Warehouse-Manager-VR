using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables.PhysicsBased;

namespace tm_vr.controllables.levers
{
    public class Controllable_Sender : MonoBehaviour {
        public VRTK_PhysicsRotator lever;
        public float currVal = 0.0f;
        public Controllable_Reciever reciever;
        public string axisName;
        public int currindx = 0;
        public Controllable_Reciever[] panelControllables;
        // Use this for initialization
        void Start() {
            foreach(Controllable_Reciever recieve in panelControllables)
            {
                if(recieve.index == currindx)
                {
                    recieve.isActiveControllable = true;
                    reciever = recieve;
                }
                else
                {
                    recieve.isActiveControllable = false;
                }
            }
            
        }

        // Update is called once per frame
        void Update() {
             foreach (Controllable_Reciever recieve in panelControllables)
            {
                if (recieve.index == currindx)
                {
                    recieve.isActiveControllable = true;
                    reciever = recieve;
                }
                else
                {
                    recieve.isActiveControllable = false;
                }
            }
             
            currVal = lever.GetStepValue(lever.GetValue());
            reciever.Recieve_Axis_Value(axisName, currVal,currindx);

            
        }

    }
}
