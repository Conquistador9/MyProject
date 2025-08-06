using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _timerTime;

    private void Update()
    {
        if (!_player)
        {
            _timerTime.SetActive(false);
            _panel.SetActive(true);
            _timer.OnGameOver();
            _timer.UpdateAllTexts();
        }
    }
}