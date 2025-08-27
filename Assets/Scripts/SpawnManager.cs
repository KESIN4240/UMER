using UnityEngine;
using UnityEngine.Animations;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    public int xRange;
    public float spawnPositionZ;
    public float startDelay = 2;
    public float repeatRange = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), startDelay, repeatRange);
    }    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnAnimal()
    {
        Vector3 spawnPosition = new Vector3 (Random.Range(-xRange,xRange), 0, spawnPositionZ);
        int randomAnimal = Random.Range(0, animals.Length);
        Instantiate(animals[randomAnimal], spawnPosition, animals[randomAnimal].transform.rotation);
    }
}
