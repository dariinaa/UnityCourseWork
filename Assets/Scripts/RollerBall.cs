using UnityEngine;

public class RollerBall : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;
    private readonly float speed = .3f;  
    private Rigidbody rb;

    public Transform RespawnPoint
    {
        get => respawnPoint;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new (horizontal, 0.0f,  vertical);
        rb.AddForce (direction * speed);
    }
}
