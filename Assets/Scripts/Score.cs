using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;

    private float waitTime = 1.0f; // Wait this amount of time before generating a new obstacle
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Preorders";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            score += 10;

            scoreText.text = score.ToString() + " Preorders";

            timer = timer - waitTime; // Resets the timing interval
        }
    }
}
