using System.Collections;
using UnityEngine;

public class PlaySong : MonoBehaviour
{
    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        StartCoroutine(SongActiveTime());
    }

    private IEnumerator SongActiveTime()
    {
        yield return new WaitForSeconds(10);
        _audio.enabled = true;
    }
}