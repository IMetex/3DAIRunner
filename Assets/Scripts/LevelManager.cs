using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    //public GameObject RestartPanel;
    public static LevelManager LevelManagerInstance;

    [Header("UI Elements Visibiliy")]
    public GameObject playText;
    public GameObject gameText;
    public GameObject levelProgressBar;
    public GameObject inRangingSystem;
    public GameObject star;
    public bool gameState;


    void Start()
    {
        gameState = false;
        LevelManagerInstance = this;
    }
    public void StartTheGame()
    {
        gameState = true;
        playText.SetActive(false);
        gameText.SetActive(false);
        levelProgressBar.SetActive(true);
        star.SetActive(true);
        inRangingSystem.SetActive(true);
    }
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
