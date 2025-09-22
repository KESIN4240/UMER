using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public int speed = 10;

    private PlayerControlier playerControlier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControlier = FindObjectOfType<PlayerControlier>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlier.isGameOver != true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
