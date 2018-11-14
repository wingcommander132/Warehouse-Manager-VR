using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
    public int numPackages = 0;
    public int packagesStored = 0;
    public int packagesLeft = 0;
    public Text progressText;

    public GameObject winPanel;
    public GameObject failPanel;
	// Use this for initialization
	void Start () {
        numPackages = GameObject.FindGameObjectsWithTag("Package").Length;
        packagesLeft = numPackages;
	}
	
	// Update is called once per frame
	void Update () {
		if(packagesLeft == 0 && numPackages > 0)
        {
            TriggerWin();
        }

        progressText.text = packagesLeft + "/" + numPackages;
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Package")
        {
            packagesLeft--;
            other.gameObject.tag = "DonePackage";
        }
        
    }

    void TriggerWin()
    {
        winPanel.SetActive(true);
    }

    void TriggerLoose()
    {
        failPanel.SetActive(false);
    }
}
