using BallGame.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject OneBallPrefab;
    private bool GameOver;
    private ScoreBoard scoreBoard;

    private Text ScoreText;
    private Button PlayAgainButton;

    public GameController()
    {
        scoreBoard = new ScoreBoard();

    }

    void Start()
    {
        GameOver = true;
        ScoreText = GameObject.Find("ScoreTxtLbl").GetComponent<Text>(); 
        PlayAgainButton = GameObject.Find("PlayAgainBtn").GetComponent<Button>();
        this.repeatBall();
    }

    
    void FixedUpdate()
    {
       this.createBall();
       ScoreText.text = "Score: " + scoreBoard.getCurrentScore().ToString();
 
    }

    private void repeatBall()
    {
        waitingCoroutine();       
    }
    private void createBall()
    {       
        if (!GameOver) { 
            Instantiate(OneBallPrefab);
            scoreBoard.increaseAmountOfBalls();
            if (scoreBoard.getAmountofBalls() == scoreBoard.getAmountOfMaxBalls())
            {                
                GameOver = true;
                PlayAgainButton.gameObject.SetActive(true);
            }
        }
    }
    private IEnumerator waitingCoroutine()
    {
        this.createBall();
        yield return new WaitForSeconds(0.2f);
    }
    public bool gameOverState()
    {
        return this.GameOver;
    }

    public ScoreBoard getScoreBoard()
    {
        return this.scoreBoard;
    }

    public void StartGame()
    {
        this.destroyAllBalls();
        PlayAgainButton.gameObject.SetActive(false);
        scoreBoard.setinitialScore(0);
        scoreBoard.setinitialNumberofBalls(0);
        GameOver = false;
       
    }

    private void destroyAllBalls()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("GameController"))
        {
            Destroy(ball);
        }
    }

}
