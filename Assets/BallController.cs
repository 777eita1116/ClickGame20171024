﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    
	// Use this for initialization
	void Start ()
    {
       // Shoot(new Vector3(0, 200, 2000));	
	}
	


	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
	
	}
}
