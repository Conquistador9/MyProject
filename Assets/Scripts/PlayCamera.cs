using UnityEngine;

public class PlayCamera : MonoBehaviour
{
    [SerializeField] private GameObject _virtualCamera;

    public void CameraPlay() => _virtualCamera.SetActive(false);
}