using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundUI : MonoBehaviour
{
    [SerializeField] private GameObject _soundOff;
    [SerializeField] private GameObject _soundOn;

    public void SpriteOff()
    {
        _soundOff.SetActive(false);
        _soundOn.SetActive(true);
    }

    public void SpriteOn()
    {
        _soundOn.SetActive(false);
        _soundOff.SetActive(true);
    }
}