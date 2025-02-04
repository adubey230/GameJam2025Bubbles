using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    [SerializeField] private Points _points;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        _points.ChangePoints(1);
        Destroy(_gameObject);

        Debug.Log("Bubble popped");
    }
}
