using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Animator animator;

    public float speed;
    // Jump
    bool onGround;
    private Rigidbody rb;
    public float jump;
    // Dash
    public float multiplier =1;

	// Use this for initialization
	void Start () {
        onGround = true;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-speed * Time.deltaTime* multiplier, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(speed * Time.deltaTime*multiplier, 0, 0);
        }

        // Dash

        if (Input.GetKey(KeyCode.V))
        {
            multiplier = 2f;
        }
        else
        {
            multiplier = 1;
        }

        // Jump

        if (onGround)
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
                rb.velocity = new Vector3(0, jump, 0);
                onGround = false;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
}
