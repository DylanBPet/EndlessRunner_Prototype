using UnityEngine;

public class DoubleJumpDetectionScript : MonoBehaviour
{
    public PlayerMovementScript playerMoveScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerMoveScript.doubleJumping = 0;
        Debug.Log("collision Enter");
    }
}
