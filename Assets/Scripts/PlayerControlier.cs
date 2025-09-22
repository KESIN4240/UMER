using UnityEngine;

public class PlayerControlier : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    public bool isGameOver;

    private Rigidbody rigidbody;
    private bool isOnGround = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Physics.gravity = Physics.gravity * gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            isGameOver = true;

            return;
        }

        isOnGround = true;
    }
}
