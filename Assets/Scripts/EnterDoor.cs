using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDoor : MonoBehaviour {

    public GameObject Player;
    public GameObject Cam;
    public GameObject Room;
    public GameObject Door;
    public bool Doorhight = false;


    public float zoom;

// Update is called once per frame
void Update()
    {
        if (Doorhight)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                Player.transform.position = Door.transform.position-new Vector3(0,.9f,0);
                Cam.transform.position=Room.transform.position;
                Camera.main.orthographicSize = zoom;
            }
            Doorhight = false;
        }
        
        
    }

    void OnTriggerStay(Collider thisDoor)
    {
        
        if (thisDoor.gameObject.tag == "Player") 
        {
            Doorhight = true;
        }
    }   
}
