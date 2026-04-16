using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    /*
    [SerializeField] private GameObject _keyboardPanel;
    [SerializeField] private AudioSource _source;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void StartClick()
    {
        _keyboardPanel.SetActive(false);
        Time.timeScale = 1;
        _source.Play();
    }
    */
}