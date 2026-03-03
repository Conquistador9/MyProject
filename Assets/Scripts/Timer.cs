using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText, _maxTimeText, _currentTimeText;
    private float _time, _maxTime, _currentTime;
    private bool _isGameOver = false;

    private void Start()
    {
        _maxTime = PlayerPrefs.GetFloat("MaxTime", 0f); 
        _currentTime = PlayerPrefs.GetFloat("CurrentTime", 0f);
        UpdateAllTexts();
    }

    private void Update()
    {
        if (_isGameOver)
            return;

        _time += Time.deltaTime;
        _currentTime = _time;

        if (_currentTime > _maxTime)
            _maxTime = _currentTime;

        UpdateAllTexts();
    }

    public void OnGameOver()
    {
        _isGameOver = true;
        PlayerPrefs.SetFloat("MaxTime", _maxTime);
        PlayerPrefs.SetFloat("CurrentTime", _currentTime);
        PlayerPrefs.Save();
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
}