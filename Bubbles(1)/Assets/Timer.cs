using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private Points _points;
    [SerializeField] private float _maxTimeSeconds = 30.0f;
    private float _timeRemaining;
    private bool _runGame;

    // Start is called before the first frame update
    void Start()
    {
        _runGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(_runGame == true) 
        {
            _timeRemaining = _maxTimeSeconds -= Time.deltaTime;
            _points.SecondsRemaining(_timeRemaining);

            
            if(_maxTimeSeconds <= 0) 
            {
               
            }
        }
    }

    public void StartGame ()
    {
        _timeRemaining = _maxTimeSeconds;
        _points.SecondsRemaining(_timeRemaining);
        _runGame = true;
    }
}
