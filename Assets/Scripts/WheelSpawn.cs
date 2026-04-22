using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private AudioSource _spownSong;

    private void Start()
    {
        StartCoroutine(SpawnTime());
    }

    private IEnumerator SpawnTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(_object, _spawnPoint.position, Quaternion.Euler(0, 90, 0));
            _spownSong.Play();
        }
    }
}