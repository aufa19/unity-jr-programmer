using UnityEngine;

// INHERITANCE
public class PlayerMovement : PausableInputHandler
{
    public float jumpForce;
    public float movementSpeed;

    private Rigidbody2D myRigidbody2D;
    private Collider2D myCollider2D;

    private void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myCollider2D = GetComponent<Collider2D>();
    }

    // POLYMORPHISM
    protected override void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            myRigidbody2D.AddForce(Vector2.up * jumpForce); // jump
        }

        float xInput = Input.GetAxis("Horizontal");
        myRigidbody2D.velocity = new Vector2(xInput * movementSpeed, myRigidbody2D.velocity.y); // left/right movement
    }

    // POLYMORPHISM
    protected override void HandlePauseInInput()
    {
        myRigidbody2D.velocity = new Vector2(0, myRigidbody2D.velocity.y); // reset input on Horizontal axis to zero
    }

    // ABSTRACTION
    public bool IsGrounded()
    {
        // To check whether the player is grounded we check whether there are objects in the rectangle under it
        // The rectangle is a bit smaller than the player's collider and a bit shifted to the bottom
        // That's done in order to avoid intersections with the walls to the left and to the right and with the player

        // rectangle width: the width of the collider attached to the player - 0.2
        // rectangle height: 0.1
        // rectandle distance from the player: 0.1 to the bottom
        // rectangle top left point: A
        // rectangle bottom right point: B

        Vector2 A = new Vector2(myCollider2D.bounds.min.x + 0.1f, myCollider2D.bounds.min.y - 0.1f);
        Vector2 B = new Vector2(myCollider2D.bounds.max.x - 0.1f, myCollider2D.bounds.min.y - 0.2f);
        Collider2D objectUnderThePlayer = Physics2D.OverlapArea(A, B);

        if (!(objectUnderThePlayer is null))
        {
            Debug.Log("I can jump because I stand on " + objectUnderThePlayer.gameObject.name);
            return true;
        }
        return false;
    }
}
