using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    public float speed = 5;

    private Vector2 movement;

    private Rigidbody2D rb;

    public float jumpForce;

    public int doubleJumping;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        doubleJumping = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0,0,0);
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        if (doubleJumping < 2)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                doubleJumping++;
            }
        } 
    }

    void FixedUpdate()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 checkIfw = context.ReadValue<Vector2>();
        if (checkIfw.y != 0)
        {

        }
        else
        {
            movement = context.ReadValue<Vector2>();
        }
            

    }
    
}
