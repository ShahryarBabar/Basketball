using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public Ball ball;
    public GameObject PlayerCamera;
    public float BallDistance = 2f;
    public float BallThrowingForce = 5f;

    public bool HoldingBall = true;

    void Start() { 

        ball.GetComponent<Rigidbody> ().useGravity = false;
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HoldingBall)
        {
            ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * BallDistance;

            if (Input.GetMouseButtonDown(0))
            {
                HoldingBall = false;
                ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * BallThrowingForce);
            }
        }
    }
}
