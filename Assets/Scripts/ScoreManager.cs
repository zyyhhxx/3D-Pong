using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text[] player1ScoreTexts;
    public Text[] player2ScoreTexts;

    public GameObject player1Zone;
    public GameObject player2Zone;

    private int player1Score;
    private int player2Score;

    // Start is called before the first frame update
    void Start()
    {
        player1Score = 0;
        player2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var text in player1ScoreTexts)
        {
            text.text = "Player 1 Score: " + player1Score.ToString();
        }
        foreach (var text in player2ScoreTexts)
        {
            text.text = "Player 2 Score: " + player2Score.ToString();
        }
    }

    public void IncreasePlayer1Score()
    {
        player1Score++;
    }

    public void IncreasePlayer2Score()
    {
        player2Score++;
    }
}
