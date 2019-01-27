using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

	public float clockSpeed;
    public bool stopClock;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!stopClock)
        {

        this.transform.Rotate(0, 0, (-360 / clockSpeed) * Time.deltaTime);
        }
		
	}
}
