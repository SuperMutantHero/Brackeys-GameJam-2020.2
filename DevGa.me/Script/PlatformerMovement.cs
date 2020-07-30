using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlatformerMovement : MonoBehaviour
{
	//Speed control items
	public float speed = 10;
	public float jumpConstant = 10;
	public float currentSpeed_H;
	public float currentSpeed_V;

	//Jump data items
	public Transform foot;
	public float radius;
	public LayerMask groundMask;

	//References


	private float inputX;
	private Rigidbody2D rb;

	[HideInInspector]
	public bool isGrounded;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		inputX = Input.GetAxisRaw("Horizontal");

		GroundCheck();

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (isGrounded)
			{
				Jump();
			}
		}
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
		currentSpeed_H = rb.velocity.x;
		currentSpeed_V = rb.velocity.y;
	}

	void Jump()
	{
		rb.velocity = new Vector2(rb.velocity.x, jumpConstant);
	}

	void GroundCheck()
	{
		if (Physics2D.OverlapCircle(foot.position, radius, groundMask))
		{
			isGrounded = true;
		}
		else {
			isGrounded = false;
		}
	}

	//Delete it after visualisation, it can cause performance issues
	void OnDrawGizmos()
	{
		Gizmos.DrawSphere(foot.position, radius);
	}
}
