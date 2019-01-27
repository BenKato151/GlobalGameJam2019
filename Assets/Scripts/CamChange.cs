using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour {

    
    public GameObject cam;
    public GameObject Room;

    void OnTriggerStay(Collider thisTrigger)
    {

        if (thisTrigger.gameObject.tag == "Player")
        {
            cam.transform.position = Room.transform.position;
        }
        

    }
}
