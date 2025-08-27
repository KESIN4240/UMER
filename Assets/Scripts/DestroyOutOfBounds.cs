using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float botBount = -5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z <= botBount)
        {
            Debug.Log("game over");
            Destroy(gameObject);
        }
        
    }

}
