using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {        

    }
}
