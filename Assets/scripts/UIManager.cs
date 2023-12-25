using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    int score = 0;
    public Text scv;
    public Text txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore(){
        score=score+10;
        scv.text="Score: " + score;

    }
    public void ScoreShow(){
        txt.text="Your Score is " + score;
    }
}
