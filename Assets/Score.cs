using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public interface IScorer {
    public void Increment();
}

public class Score : MonoBehaviour, IScorer
{
    public TMP_Text scoreBoard;

    private int score_ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        scoreBoard.text = score_.ToString();
    }

    public void Increment() {
        score_++;
    }
}
