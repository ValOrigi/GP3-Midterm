using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    private GameObject scoreBoard;
    private GameManagement gameManagement;

    private TextMeshProUGUI scoreCountText;
    private TextMeshProUGUI WinText;
    private int score;

    void Start()
    {
        scoreBoard = GameObject.Find("Score Text");
        scoreCountText = scoreBoard.GetComponent<TextMeshProUGUI>();
        WinText = scoreBoard.GetComponent <TextMeshProUGUI>();
        gameManagement = GetComponent<GameManagement>();
    }

    public void ScoreCount()
    {
        score++;
        scoreCountText.text = "Score: " + score;
        if (score == gameManagement.OrbNum)
        {
            WinText.text = "You Win";
        }
    }
}
