using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    public int turnSpeed;

    private float horizontalInput;
    private float verticalInput;
    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up , Time.deltaTime * turnSpeed * horizontalInput);

        if (gameObject.transform.position.y < -20)
        {
            gameObject.transform.position = startPosition;
            gameObject.transform.rotation = Quaternion.identity;
        }
    }
} 