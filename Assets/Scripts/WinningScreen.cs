using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningScreen : MonoBehaviour {
    public GameObject timer;
    public GameObject clock;
    public GameObject clock2;
    public GameObject win;
    bool ifWin=false;

	
	void Start () {
        
	}
	
	
	void Update ()
    {
        if (ifWin)
        {
            timer.SetActive(false);
            clock.GetComponent<Clock>().stopClock=true;
            clock2.GetComponent<Clock>().stopClock = true;
            win.SetActive(true);
        }
		
	}
    void OnTriggerEnter(Collider winner)
    {
        if(winner.gameObject.tag == "Player")
        {
            ifWin = true;
        }
    }

}
