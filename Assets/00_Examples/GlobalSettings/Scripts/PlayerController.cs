using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerSettings settings;
    
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float move = Input.GetAxis("Horizontal") * settings.MoveSpeed;
        rb.linearVelocity = new Vector3(move, rb.linearVelocity.y, 0);

        if (Input.GetButtonDown("Jump"))
            rb.AddForce(Vector3.up * settings.JumpForce, ForceMode.Impulse);
    }
}