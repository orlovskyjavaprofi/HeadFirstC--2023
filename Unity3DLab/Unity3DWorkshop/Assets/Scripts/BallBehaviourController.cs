using System.Collections;
using System.Collections.Generic;
using Unity3DWorkshop.Scripts;
using UnityEngine;

public class BallBehaviourController : MonoBehaviour
{
    private BallBehaviour ballBehaviour;

    public BallBehaviourController()
    {
        ballBehaviour = new BallBehaviour();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.rotateBall();
    }

    private void rotateBall()
    {
        Vector3 axis = new Vector3(this.ballBehaviour.getXRotation(), this.ballBehaviour.getYRotation(), this.ballBehaviour.getZRotation());
        //transform.Rotate(axis, this.ballBehaviour.getDegreesPerSecond() * Time.deltaTime);
        transform.RotateAround(Vector3.zero, axis, this.ballBehaviour.getDegreesPerSecond() * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f);
    }
}
