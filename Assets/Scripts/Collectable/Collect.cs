using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    private int score = 0;

    public bool addBall;
    public GameObject ballIcon;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Star"))
        {
            // Add Star 
            other.gameObject.SetActive(false);
            AddScore();
        }
        if (other.CompareTag("Ball"))
        {
            // Add Ball 
            addBall = true;
            // Visibility 
            other.gameObject.SetActive(false);
            ballIcon.SetActive(true);
        }
    }
    void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
