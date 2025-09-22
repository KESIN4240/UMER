using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    public float startDelay = 5;
    public float repeatRate = 2;
    public float spawnPositionX = 25;

    private PlayerControlier playerControlier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControlier = FindObjectOfType<PlayerControlier>();

        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        if (playerControlier.isGameOver != true)
        {
            Vector3 spawnPosition = new Vector3(spawnPositionX, obstacle.transform.position.y, obstacle.transform.position.z);

            Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
        }
        
    }
}
