using System.Collections;
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
        }  
    }
}