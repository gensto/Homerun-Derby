using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter : MonoBehaviour
{

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Mouse1 clicked");
            anim.SetBool("isSwinging", true);
        }
        else
        {
            anim.SetBool("isSwinging", false);
        }
    }
}
