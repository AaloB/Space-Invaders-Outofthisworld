using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public TMP_Text scoreText;


    void Start()
    {
        
    }

    public void Updatescore(int points)

    {
      score += points;
        scoreText.text = "Score: " + score;
    }



}
