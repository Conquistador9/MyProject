using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayCamera : MonoBehaviour
{
    [SerializeField] private GameObject _virtualCamera;

    public void CameraPlay()
    {
        _virtualCamera.SetActive(false);
        Debug.Log("lol");
    }
}