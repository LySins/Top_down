using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreImage : MonoBehaviour
{
    public GameObject _playerGameObject;
    public int _score = 0;
    [SerializeField] Text _scoreText;
    void Start()
    {
        _score = 0;      
    }

    // Update is called once per frame
    void Update()
    {   
        _score = _playerGameObject.GetComponent<PlayerInteraction>()._scorePlayer;
        _scoreText.text = _score.ToString();
    }
}
