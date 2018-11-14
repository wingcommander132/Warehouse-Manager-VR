using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllable_DisplayManager : MonoBehaviour {

    Controllable_SendingManager sendMan;
    public GameObject[] Displays;
    int index = 0;
    // Use this for initialization
    void Start()
    {
        sendMan = GetComponent<Controllable_SendingManager>();
        foreach (GameObject obj in Displays)
        {
            obj.SetActive(false);
        }

        Displays[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        index = sendMan.index;

        foreach (GameObject obj in Displays)
        {
            obj.SetActive(false);
        }

        Displays[index].SetActive(true);
    }
}
