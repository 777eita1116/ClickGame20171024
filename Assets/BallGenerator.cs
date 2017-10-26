using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(ballPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            ball.GetComponent<BallController>().Shoot(worldDir.normalized * 2000);
        }
	

	}
}
