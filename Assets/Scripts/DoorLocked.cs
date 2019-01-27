using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{

    public int counter;
    int counter2;

    bool itemcolision;

    void Start()
    {
        this.GetComponent<EnterDoor>().enabled = !this.GetComponent<EnterDoor>().enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 0 && counter2 == 0)
        {
            counter2++;
            this.GetComponent<EnterDoor>().enabled = !this.GetComponent<EnterDoor>().enabled;
        }
    }

}
