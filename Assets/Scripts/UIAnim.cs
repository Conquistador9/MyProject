using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnim : MonoBehaviour
{
    [SerializeField] private GameObject _buttonAnim;
    [SerializeField] private GameObject _timerImage;

    public void PlayButtonAnim() => StartCoroutine(PlayButtonAnimDelay());

    private IEnumerator PlayButtonAnimDelay()
    {
        yield return new WaitForSeconds(2f);
        _buttonAnim.SetActive(true);
        _timerImage.SetActive(true);
    }
}