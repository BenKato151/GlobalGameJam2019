using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour {

    public GameObject endscreen;

	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(Timer());
	}

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(90);
        endscreen.SetActive(true);
    }
}
