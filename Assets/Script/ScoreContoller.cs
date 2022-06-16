using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreContoller : MonoBehaviour
{
    public Text scoreKiri;
    public Text scoreKanan;

    public ScoreManager manager;

    private void Update()
    {
        
        scoreKiri.text = manager.leftScore.ToString();
        scoreKanan.text = manager.rightScore.ToString();
    }
}
