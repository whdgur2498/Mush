using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton; 
    public int score = 0; 

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    private void PointUp()
    {
        score += 1;
        Debug.Log("Score: " + score);
    }
}
