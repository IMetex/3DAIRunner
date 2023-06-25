using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFinish : MonoBehaviour
{
    private InRankingSystem ig;
    private Animator animator;
    [Header("UI Panel")]
    public GameObject winPanel;
    public GameObject losePanel;

    [Header("Access")]
    public PlayerController playerController;


    private void Start()
    {
        ig = FindObjectOfType<InRankingSystem>();
        animator = GetComponent<Animator>();
    }
    public void PlayerWin()
    {
        playerController.forwardSpeed = 0f;

        if (ig.namesTxt[4].text == "You")
        {
            winPanel.SetActive(true);
            losePanel.SetActive(false);
            // UI
            LevelManager.LevelManagerInstance.levelProgressBar.SetActive(false);
            LevelManager.LevelManagerInstance.RankingUIDeactive();
            //
            animator.SetBool("IsWin", true);
            //
            GameManager.instance.isGameOver = true;
        }
        else
        {
            losePanel.SetActive(true);
            winPanel.SetActive(false);
            LevelManager.LevelManagerInstance.levelProgressBar.SetActive(false);
            LevelManager.LevelManagerInstance.RankingUIDeactive();
            animator.SetBool("IsLose", true);
        }

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - 180f, transform.rotation.eulerAngles.z);

    }
}
