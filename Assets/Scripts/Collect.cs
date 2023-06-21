using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    public int score = 0;
    public bool addBomb;
    public GameObject bombIcon;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Star"))
        {
            other.gameObject.SetActive(false);
            AddScore();
        }
        if (other.CompareTag("Bomb"))
        {
            addBomb = true;
            other.gameObject.SetActive(false);
            bombIcon.SetActive(true);
            Debug.Log("Add");
        }
    }
    void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
