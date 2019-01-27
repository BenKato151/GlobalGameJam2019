using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoom : MonoBehaviour {

    public GameObject Cam;
    public bool isGrounded = false;

    // Use this for initialization
    void Start()
    {

    }

// Update is called once per frame
void Update()
    {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(-5, -5.5f, 0);
                Cam.transform.Translate(0, -5.5f, 0);
        }
    }

    void OnTriggerEnter(Collider player)
    {

        if (player.gameObject.tag == "Player") 
        {
            isGrounded = true;
            
        }
        else
        {
            isGrounded = false;
        }
    }
}
