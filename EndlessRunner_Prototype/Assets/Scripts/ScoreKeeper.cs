using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI ScoreBoard;
    public float score = 0;

    public TextMeshProUGUI highScoreBoard;
    public float highScore;

    void Start()
    {
        highScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        ScoreBoard.text = "Score: " + score.ToString("0.00");

        if (highScore <= score)
        {
            highScore = score;
            highScoreBoard.text = "Highscore: " + highScore.ToString("0.00");
        }

    }
}
