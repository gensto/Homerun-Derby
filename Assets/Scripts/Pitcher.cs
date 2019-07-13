using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{
    Animator anim;
    public Ball ball;

	// Use this for initialization
	void Start ()
    {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isPitching", true);
        }
        else
        {
            anim.SetBool("isPitching", false);
        }
    }

    void ThrowBall()
    {
        Debug.Log("Ball should be thrown");
        ball.moveBall();
    }
}
