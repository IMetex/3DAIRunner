using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    //public GameObject RestartPanel;
    public static LevelManager LevelManagerInstance;
    public GameObject playText;
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
    }
    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
