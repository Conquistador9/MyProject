using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private GameObject _pauseOn;
    [SerializeField] private GameObject _pauseOff;
    [SerializeField] private bool _isPaused = false;

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            AudioListener.pause = true;
            PauseOn();
        }
        else
        {
            AudioListener.pause = false;
            PauseOff();
        }
    }

    private void OnApplicationPause(bool pause)
    {
        _isPaused = pause;
    }

    public void PauseOn()
    {
        Time.timeScale = 0;
        _source.Pause();
        _pauseOn.SetActive(false);
        _pauseOff.SetActive(true);
    }

    public void PauseOff()
    {
        Time.timeScale = 1;
        _source.UnPause();
        _pauseOff.SetActive(false);
        _pauseOn.SetActive(true);
    }
}