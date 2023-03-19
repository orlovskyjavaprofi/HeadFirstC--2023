using BallGame.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OneBallBehaviourController : MonoBehaviour
{
    private OneBallBehaviour oneBallBehaviour;
    private GameController gameController;
    private ScoreBoard scoreBoard;
    public OneBallBehaviourController()
    {
        oneBallBehaviour = new OneBallBehaviour();
    }
    void Start()
    {
        this.randomBallPosition();
        gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        scoreBoard = GameObject.Find("GameManager").GetComponent<GameController>().getScoreBoard();
    }

    void Update()
    {
        this.rotateBallAround();
        this.userClickedLeftMouseButton();
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

    private void userClickedLeftMouseButton()
    {        
        if (Input.GetMouseButtonDown(0))
        {
            if (!gameController.gameOverState())
            {
                scoreBoard.ClickedOnBall();
                Destroy(gameObject);
            }
        }
    }
}
