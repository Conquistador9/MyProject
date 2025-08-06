using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        StartCoroutine(SpawnTime());
    }

    private IEnumerator SpawnTime()
    {
        float time = Random.Range(1, 2);

        while (true)
        {
            yield return new WaitForSeconds(1);
            Instantiate(_object, _spawnPoint.position, Quaternion.Euler(0, 90, 0));
        }
        
    }
}