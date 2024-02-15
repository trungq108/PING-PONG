using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle computerPaddle;
    public Paddle playerPaddle;
    private int playerScore;
    private int computerScore;
    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text computerScoreText;
    public void PlayerScore()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void ComputerScore()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetRound();
    }
    private void ResetRound()
    {
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPositon();
        computerPaddle.ResetPositon();
    }
}
