using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InRankingSystem : MonoBehaviour
{
   public Text[] namesTxt;
    public string a, b, c, d, e;

    private void Update()
    {
        namesTxt[0].text = a;
        namesTxt[1].text = b;
        namesTxt[2].text = c;
        namesTxt[3].text = d;
        namesTxt[4].text = e;
    }
}
