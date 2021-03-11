using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceMultiplier = 3f;
    public float maxVelocity = 3f;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // this.rigidBody.addForce()
        float horizontalInput = Input.GetAxis("Horizontal");
        if (rigidBody.velocity.magnitude <= maxVelocity)
        {
            rigidBody.AddForce(new Vector3(horizontalInput * forceMultiplier, 0, 0));
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
        }
    }




}
