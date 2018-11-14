using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tm_vr.controllables.levers
{
    public class Controllable_Reciever : MonoBehaviour
    {
        public float xAxis = 0.0f;
        public float yAxis = 0.0f;
        public float controlableAxis = 0.0f;
        public NewCarController vehicleController;
        public ForkController forkController;
        public int index = 0;
        public bool isActiveControllable = false;
        public GameObject activeLight;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isActiveControllable)
            {
                activeLight.SetActive(true);
                vehicleController.Move(-xAxis, yAxis, yAxis, 0.0f);
                forkController.input = controlableAxis;
            }
            else
                activeLight.SetActive(false);
        }

        public void Recieve_Axis_Value(string axisName, float val,int indx)
        {
            if (indx == index)
            {
                if (axisName == "x")
                    xAxis = val;
                else
                if (axisName == "y")
                    yAxis = val;
                else
                if (axisName == "fork")
                    controlableAxis = val;

            }
        }
    }
}