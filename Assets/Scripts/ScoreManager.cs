using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        score = 0;
    }

    // Update is called once per frame
    public void addScore()
    {
        score++;
        uiManager.UpadateScore(score);
    }

    public void AddScore(int Scorepoints)
    {
        score += Scorepoints;
        uiManager.UpadateScore(score);
    }
}
