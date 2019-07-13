using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFollower : MonoBehaviour {

    GameObject target;
    Vector3 previous;

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        Debug.Log("YEAAAAAAAD");
        gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        rb.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        rb.rotation = target.transform.rotation;
        rb.velocity = ((rb.position - previous)) / Time.deltaTime;

        previous = rb.position;
    }

    public void FollowTarget(GameObject target)
    {
        Debug.Log("Greetings dumbasses");
        this.target = target;
    }
}
