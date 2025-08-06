using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText, _maxTimeText, _currentTimeText;
    private float _time, _maxTime, _currentTime;
    private bool _isGameOver = false;

    private void Start()
    {
        _maxTime = PlayerPrefs.GetFloat("MaxTime", 0f); // по умолчанию 5 минут
        _currentTime = PlayerPrefs.GetFloat("CurrentTime", 0f);
  //      _time = 0f;

        UpdateAllTexts();
    }

    private void Update()
    {
        if (_isGameOver)
            return;

        _time += Time.deltaTime;
        _currentTime = _time;

        if (_currentTime > _maxTime)
        {
            _maxTime = _currentTime;
        }

        UpdateAllTexts();
    }

    // Ётот метод вызываетс€, когда игра заканчиваетс€
    public void OnGameOver()
    {
        _isGameOver = true;

        // —охран€ем данные только при завершении игры
        PlayerPrefs.SetFloat("MaxTime", _maxTime);
        PlayerPrefs.SetFloat("CurrentTime", _currentTime);
        PlayerPrefs.Save();

        Debug.Log("ƒанные сохранены!");
    }

    public void UpdateAllTexts()
    {
        int minutes = Mathf.FloorToInt(_time / 60f);
        int seconds = Mathf.FloorToInt(_time % 60f);
        _timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        int maxMinutes = Mathf.FloorToInt(_maxTime / 60f);
        int maxSeconds = Mathf.FloorToInt(_maxTime % 60f);
        _maxTimeText.text = string.Format("{0:00}:{1:00}", maxMinutes, maxSeconds);

        int currentMinutes = Mathf.FloorToInt(_currentTime / 60f);
        int currentSeconds = Mathf.FloorToInt(_currentTime % 60f);
        _currentTimeText.text = string.Format("{0:00}:{1:00}", currentMinutes, currentSeconds);
    }




    /*
    [SerializeField] private TMP_Text _timerText, _maxTimeText, _currentTimeText;
    private float _time, _maxTime, _currentTime;

    private void Start()
    {
        TimerText();
    }

    private void Update()
    {
        _time = Time.time;
        TimerText();
    }

    private void TimerText()
    {
        int minutes = Mathf.FloorToInt(_time / 60f);
        int seconds = Mathf.FloorToInt(_time % 60f);
        _timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    */
}