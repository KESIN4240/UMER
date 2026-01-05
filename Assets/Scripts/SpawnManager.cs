using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(enemy,new Vector3(0,0,6), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
