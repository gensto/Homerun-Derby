using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour {

    public GameObject batFollower;
    public GameObject fingerPos;
    public Rigidbody rb;

    public Vector3 offset;
    public Vector3 rotationOffset;

    [SerializeField]
    private BatFollower _batFollowerPrefab;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("So the name of THIS object is: " + this.gameObject.tag);
        BatFollower bF = Instantiate(_batFollowerPrefab);
        bF.FollowTarget(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {

        //rb.position = new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z);
    }
}
