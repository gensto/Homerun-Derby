using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Rigidbody rb;
    public Vector3 initialPos;
    public GameObject finger;

    public GameObject cameraFollow;


    CameraFollow cF;

    // Use this for initialization
    void Start () {
        initialPos = rb.position;
        // rb.velocity = new Vector3(0, 0, -8);
        Debug.Log("So the name of THIS object is: " + this.gameObject.tag);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K))
        {
            rb.position = initialPos;
            rb.velocity = new Vector3(0, 0, -8);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.position = finger.transform.position;
            this.gameObject.transform.position = finger.transform.position;
            this.gameObject.transform.parent = finger.transform;
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Bat Follower")
        {
            Debug.Log("Hit");
            float BESR = 0.65f;
            Vector3 batV = obj.rigidbody.velocity;
            Debug.Log(batV);
            Vector3 pitchV = rb.velocity;
            Vector3 exitV = (BESR + 0.5f)*batV + (BESR - 0.5f)*pitchV;
            exitV = new Vector3(exitV.x, Mathf.Abs(exitV.y)*2, exitV.z);
            rb.velocity = exitV*2;
            rb.useGravity = true;
            cameraFollow.GetComponent<CameraFollow>().isBallHit = true;
            //rb.velocity = new Vector3(0, 10, 10);
        }
        if(obj.gameObject.tag == "Floor")
        {
            rb.useGravity = false;
        }
        if (obj.gameObject.tag == "Wall")
        {
            rb.velocity = new Vector3(0,0,0);
        }
        if (obj.gameObject.tag == "Homerun")
        {
            Debug.Log("Homerun bro");
        }
    }

    public void moveBall()
    {
        rb.transform.parent = null;
        rb.velocity = new Vector3(-0.15f, -0.30f, -8);
    }
}
