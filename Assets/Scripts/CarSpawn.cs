using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _cars;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(CarTime());
    }

    private IEnumerator CarTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            int randomCarIndex = Random.Range(0, _cars.Length);
            GameObject carToSpawn = _cars[randomCarIndex];

            int randomIndex = Random.Range(0, _spawnPoints.Length);
            Transform spawnPoint = _spawnPoints[randomIndex];

            Quaternion spawnRotation;

            if(randomCarIndex == 0)
            {
                spawnRotation = Quaternion.Euler(0, 90, 0);
            }
            else if(randomCarIndex == 1)
            {
                spawnRotation = Quaternion.Euler(270, 180, 0);
            }
            else
            {
                spawnRotation = Quaternion.identity;
            }
            
            Instantiate(carToSpawn, spawnPoint.position, spawnRotation);
        }
    }
}