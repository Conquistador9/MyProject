using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseOn;
    [SerializeField] private GameObject _pauseOff;

    public void PauseOn()
    {
        Time.timeScale = 0;
        _pauseOn.SetActive(false);
        _pauseOff.SetActive(true);
    }

    public void PauseOff()
    {
        Time.timeScale = 1;
        _pauseOff.SetActive(false);
        _pauseOn.SetActive(true);
    }
}