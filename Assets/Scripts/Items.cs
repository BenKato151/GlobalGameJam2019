using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

    bool playerOnKey = false;

    void Start()
    {
        this.GetComponentInParent<DoorLocked>().counter += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOnKey)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                this.GetComponentInParent<DoorLocked>().counter -= 1;
                Destroy(this.gameObject);
            }

        }

    }
    void OnTriggerStay(Collider thisitem)
    {

        if (thisitem.gameObject.tag == "Player")
        {
            playerOnKey = true;

        }

    }
}
