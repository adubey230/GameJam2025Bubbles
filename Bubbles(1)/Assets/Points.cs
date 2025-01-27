using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Text _timerText;
    private int total_points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePoints(int score)
    {
        total_points += score;
        _text.text = "Points:" + total_points;
    }

    public void SecondsRemaining(float seconds)
    {
        _timerText.text = "Time Remaining: " + seconds.ToString("N0");
    }
}
