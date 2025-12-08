using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed;
    public Transform focalPoint;

    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        rigidbody.AddForce(focalPoint.forward * moveSpeed * verticalInput);
    }
}
