using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    Camera mainCamera;
    public GameObject selectLevelPanel;

    public Rigidbody2D ball;
    public Transform startPos;
    bool currentGameState = false;//true = Play Mode
    //score
    public Text ballCounterLbl;
    static Text _ballCounterLbl;
    static int ballHits = 0;

    public static void AddScore(int inc = 1)
    {
        ballHits += inc;
        _ballCounterLbl.text = ballHits.ToString();
    }

    void SetGameState(bool isPlay)
    {
        if (isPlay)
        {
            ball.simulated = true;
            selectLevelPanel.SetActive(false);
        }
        else
        {
            ball.simulated = false;
            selectLevelPanel.SetActive(true);
        }
        currentGameState = isPlay;
    }

    public void LoadLevel(LevelSettings level)
    {
        //level settings
        mainCamera.backgroundColor = level.backgroundColor;
        Physics2D.gravity = new Vector2(0, level.gravity);
        //UI
        SetGameState(true);
        //ball
        ball.transform.position = startPos.position;
        ball.velocity = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) SetGameState(!currentGameState);
    }

    private void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        _ballCounterLbl = ballCounterLbl;
    }
}
