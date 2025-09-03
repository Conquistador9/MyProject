using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _car;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        StartCoroutine(CarTime());
    }

    private IEnumerator CarTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(_car, _spawnPoint.position, Quaternion.Euler(0, 90, 0));
        }
    }
}