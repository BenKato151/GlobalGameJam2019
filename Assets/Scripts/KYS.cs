using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KYS : MonoBehaviour {

    public GameObject GameOverScreen;

    bool standOnChair = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(standOnChair)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
            GameOverScreen.SetActive(true);
            }
            standOnChair = false;

        }
	}

    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            
            standOnChair = true;
        }
    }
}
