using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _gameObject;
    [SerializeField] Button _button;

    public void RestartGame()
    {
       _gameObject.SetActive(true);
       _button.onClick.AddListener(SetGame); 
    }
    private void SetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
