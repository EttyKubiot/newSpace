using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator animator;

    [SerializeField] private float moveSpeed = 80f;
    [SerializeField] private float rotateSpeed = 300f;

    private const string VERTICAL_AXIS = "Vertical";
    private const string HORIZONTAL_AXIS = "Horizontal";

    private float moveInput;
    private float rotateInput;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       moveInput = Input.GetAxis(VERTICAL_AXIS) * moveSpeed;
       rotateInput = Input.GetAxis(HORIZONTAL_AXIS) * rotateSpeed;
    }

    private void FixedUpdate()
    {

        
            Vector3 rotation = Vector3.up * rotateInput;
            Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

            rb.MovePosition(transform.position + transform.forward * moveInput);
            rb.MoveRotation(rb.rotation * angleRot);

        }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fire"))
        {
           animator.SetBool("isUp", true);
        }
           

    }
}
