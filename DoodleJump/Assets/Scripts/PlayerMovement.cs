using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpSpeed = 20f;

    Rigidbody rb;

    public InputActionAsset actionAsset;
    InputAction move;
    InputAction jump;

    private void OnEnable()
    {
        actionAsset.Enable();
    }
    private void OnDisable()
    {
        actionAsset.Disable();
    }
    private void Awake()
    {
        move = actionAsset.FindAction("Move");
        jump = actionAsset.FindAction("Jump");
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(move.ReadValue<float>() * speed, rb.velocity.y);
        if (jump.WasPerformedThisFrame())
        {
            print("jump");
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }

        //map bounds
        transform.position = Util.setX(transform.position, 
            Mathf.Clamp(transform.position.x, -0.5f*GameManager.Instance.MapWidth, 0.5f * GameManager.Instance.MapWidth)
        );
    }
}
