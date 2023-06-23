using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private InRankingSystem ig;

    private GameObject[] runners;
    List<Ranking> sortArray = new List<Ranking>();

    public bool isGameOver = false;

    private void Awake()
    {
        instance = this;
        runners = GameObject.FindGameObjectsWithTag("Runner");
        ig = FindObjectOfType<InRankingSystem>();

    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < runners.Length; i++)
        {
            sortArray.Add(runners[i].GetComponent<Ranking>());
        }
    }

    void CalculateRank()
    {
        sortArray = sortArray.OrderBy(x => x.distance).ToList();
        sortArray[0].rank = 1;
        sortArray[1].rank = 2;
        sortArray[2].rank = 3;
        sortArray[3].rank = 4;
        sortArray[4].rank = 5;


        ig.a = sortArray[4].name;
        ig.b = sortArray[3].name;
        ig.c = sortArray[2].name;
        ig.d = sortArray[1].name;
        ig.e = sortArray[0].name;

    }

    // Update is called once per frame
    void Update()
    {
        CalculateRank();

    }
}
