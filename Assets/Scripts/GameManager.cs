using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public static GameManager instance;
        public int player1Score = 0;
        public int player2Score = 0;
        public TextMeshProUGUI player1ScoreText;
        public TextMeshProUGUI player2ScoreText;


    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int player)
    {
        if (player == 1)
        {
            player1Score++;
            //Debug.Log("Player 1 scored! Total score: " + player1Score);
        }
        else if (player == 2)
        {
            player2Score++;
            //Debug.Log("Player 2 scored! Total score: " + player2Score);
        }
        UpdateScoreHUD();

    }

    void UpdateScoreHUD()
    {
        player1ScoreText.text = "Player 1: " + player1Score;
        player2ScoreText.text = "Player 2: " + player2Score;
    }
}
