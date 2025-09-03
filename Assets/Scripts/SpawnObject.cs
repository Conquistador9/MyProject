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
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            Instantiate(_object, _spawnPoint.position, Quaternion.identity);  
            

/*
            float time = Random.Range(2,4);
            yield return new WaitForSeconds(2.5f);
            GameObject randomObject = _object[Random.Range(0, _object.Length)];
            Instantiate(randomObject, _spawnPoint.position, Quaternion.Euler(0, 90, 0)); */
        }
        
    }
}