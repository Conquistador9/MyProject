using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject _soundButton;

    public void RestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _soundButton.SetActive(true);

    } 
}