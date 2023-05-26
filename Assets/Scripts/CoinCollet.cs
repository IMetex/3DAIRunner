using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollet : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            AddScore();
        }
    }
    void AddScore()
    {
        score++;
        scoreText.text = "Score:" + score.ToString();
    }

}
