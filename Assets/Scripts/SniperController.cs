﻿using UnityEngine;
using System.Collections;

public class SniperController : MonoBehaviour {

    public float speed;
    private Vector3 sniperPos;
    private bool movingRight = true;

    // Use this for initialization
    void Start ()
    {
        //sniper enemies are controlled by empty parent object
        //they will shift between -20 < x < 20
        // |   >          <       |
        sniperPos = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        SniperDirection();
        MoveInDirection();
        print(sniperPos);
    }

    private void SniperDirection()
    {
        //changes direction at edge of playspace, set to x= -20, 20
        if (sniperPos.x < -20)
        {
            movingRight = true;
        }
        if (sniperPos.x > 20)
        {
            movingRight = false;
        }
    }

    private void MoveInDirection()
    {
        float prevPosition = transform.position.x;

        //move the formation left/right based on bool
        if (movingRight)
        {
            sniperPos = new Vector3 (prevPosition+speed, 0, 0); 
        }
        else
        {
            sniperPos = new Vector3(prevPosition-speed, 0, 0);
        }
        sniperPos = transform.position;
    }
}

