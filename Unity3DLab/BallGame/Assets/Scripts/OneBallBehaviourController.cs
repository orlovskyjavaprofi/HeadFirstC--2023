using BallGame.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBallBehaviourController : MonoBehaviour
{
    private OneBallBehaviour oneBallBehaviour;
    private ScoreBoard scoreBoard;
    public OneBallBehaviourController()
    {
        oneBallBehaviour = new OneBallBehaviour();
        scoreBoard = new ScoreBoard();
    }
    void Start()
    {
        this.randomBallPosition();
    }

    void Update()
    {
        this.rotateBallAround();
    }

    void OnMouseDown()
    {
        GameController controller = Camera.main.GetComponent<GameController>();
        scoreBoard.ClickedOnBall();
        Destroy(gameObject);
    }

    private void rotateBallAround()
    {
        Vector3 axis = new Vector3(oneBallBehaviour.getXRotation(), oneBallBehaviour.getYRotation(), oneBallBehaviour.getZRotation());
        transform.RotateAround(Vector3.zero, axis, oneBallBehaviour.getDegreesPerSecond() * Time.deltaTime);

    }
    private void randomBallPosition()
    {
        transform.position = new Vector3(3 - Random.value * 6,  3 - Random.value * 6, 3 - Random.value * 6);

    }
}
