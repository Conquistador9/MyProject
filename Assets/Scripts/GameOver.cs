using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private UIAnim _uiAnim;
    [SerializeField] private PlayCamera _playCamera;
    [SerializeField] private Timer _timer;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _timerTime;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _soundButton;
    [SerializeField] private GameObject _soundOffButton;

    private void Update()
    {
        if (!_player)
        {
            _timerTime.SetActive(false);
            _panel.SetActive(true);
            _timer.OnGameOver();
            _timer.UpdateAllTexts();
            _playCamera.CameraPlay();
            _uiAnim.PlayButtonAnim();
            _pauseButton.SetActive(false);
            _soundButton.SetActive(false);
            _soundOffButton.SetActive(false);
        }
    }
}