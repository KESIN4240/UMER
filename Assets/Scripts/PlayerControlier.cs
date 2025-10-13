using UnityEngine;

public class PlayerControlier : MonoBehaviour
{
    public float jumpForce;
    public float gravityModifier;
    public bool isGameOver;
    public AudioClip jumpclip;
    public AudioClip crashClip;
    public ParticleSystem crashParticle;
    public ParticleSystem dirtParticle;

    private Rigidbody rigidbody;
    private Animator animator;
    private AudioSource audioSource;
    private bool isOnGround = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        Physics.gravity = Physics.gravity * gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true && isGameOver == false)
        {
            rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            isOnGround = false;
            animator.SetTrigger("Jump_trig");
            audioSource.PlayOneShot(jumpclip);
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            isGameOver = true;

            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);
            audioSource.PlayOneShot(crashClip);
            crashParticle.Play();
            dirtParticle.Stop();
            return;
        }

        isOnGround = true;
        dirtParticle.Play();
    }
}
