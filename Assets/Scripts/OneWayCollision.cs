using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayCollision : MonoBehaviour {

    public GameObject player;
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.y <= this.transform.position.y + (0.5f * this.transform.localScale.y))
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
        else this.GetComponent<BoxCollider>().isTrigger = false;
	}
}
