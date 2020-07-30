using UnityEngine;

[RequireComponent(typeof(PlatformerMovement))]

public class PlayerAnimation : MonoBehaviour
{
	public Animator animator;

	private PlatformerMovement playerMovementScript;

	private float speedOfThePlayer_H;
	private float speedOfThePlayer_V;

	private bool isGrounded;

	void Start()
	{
		playerMovementScript = GetComponent<PlatformerMovement>();
	}

	void Update()
	{
		speedOfThePlayer_H = Mathf.Abs(playerMovementScript.currentSpeed_H);
		speedOfThePlayer_V = playerMovementScript.currentSpeed_V;

		isGrounded = playerMovementScript.isGrounded;

		animator.SetFloat("currentSpeed", speedOfThePlayer_H);
		animator.SetFloat("VerticalSpeed", speedOfThePlayer_V);

		animator.SetBool("IsGrounded", isGrounded);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			animator.SetTrigger("JumpStart");
		}
	}
}
