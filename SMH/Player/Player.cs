using UnityEngine;

public class Player : MonoBehaviour
{
	public Arrow arrowScript;
	public Transform arrow;
	public Transform foot;

	public float force;
	public float radius;
	public LayerMask groundLayer;
	public bool isGrounded;

	private Rigidbody2D rb;
	private Collider2D thisCollider;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		thisCollider = GetComponent<Collider2D>();

	}

	void Update()
	{
		CheckGround();

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			Jump();
		}
	}

	void Jump()
	{
		Vector2 direction;
		direction = arrow.up;

		rb.AddForce(direction * force);
	}

	void CheckGround()
	{
		if (thisCollider.IsTouchingLayers(groundLayer))
		{
			isGrounded = true;
			SetArrow(true);
		}
		else {
			isGrounded = false;
			SetArrow(false);
		}
	}

	void SetArrow(bool choice)
	{
		arrowScript.shouldRotate = choice;
	}
}
