using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = playerScore.ToString("D4");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore(int value)
    {
        playerScore += value;
        scoreText.text = playerScore.ToString("D4");
    }
}