using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    private Transform player;

    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        player = FindAnyObjectByType<PlayerControler>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDeriction = (player.position - transform.position).normalized;
        rigidbody.AddForce(moveDeriction * moveSpeed);
    }
}
