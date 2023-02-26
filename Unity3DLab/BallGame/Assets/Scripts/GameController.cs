using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject OneBallPrefab;

    void Start()
    {
        this.repeatBall();
    }

    
    void Update()
    {
       this.createBall();
    }

    private void repeatBall()
    {
        InvokeRepeating("createBall", 1.5F, 1);
    }
    private void createBall()
    {
        Instantiate(OneBallPrefab);
    }
}
