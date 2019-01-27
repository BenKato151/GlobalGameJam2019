using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseStairs_cursed : MonoBehaviour {

    bool stairs=true;
    public GameObject player;
    public GameObject cam;
    public GameObject room;
    public GameObject stairsEnd;

    public float Zoom;

    void Update ()
    {
        if (stairs)
        {
            Debug.Log("true");
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                player.transform.position = stairsEnd.transform.position - new Vector3(0, .9f, 0);
                cam.transform.position = room.transform.position;
                Camera.main.orthographicSize = Zoom;
                player.GetComponent<Movement>().jump = 8;
                stairs = false;

            }
            
        }
	}

    void OnTriggerEnter(Collider HallO)
    {

        if (HallO.gameObject.tag == "Player")
        {
            stairs = true;
        }
        else stairs = false;
        
    }
}
