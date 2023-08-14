using Leftovers_2DPlatformer.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Leftovers_2DPlatformer
{
    public class PlayerUnit : UnitBase
    {
		
		private Inputs inputs;
		
		private Vector2 move;

		[SerializeField]
		private float jumpHeight;

		private new SpriteRenderer renderer;

		private new Rigidbody2D rigidbody;

		[SerializeField]
		private Bomb bombPrefab;

		private Vector2 shootDirection;

		private Animator animator;

		protected override void Awake()
		{
			base.Awake();

			inputs = new Inputs();

			rigidbody = GetComponent<Rigidbody2D>();

			renderer = GetComponent<SpriteRenderer>();

			animator = GetComponent<Animator>();
		}

		protected override void Start()
		{
			base.Start();

			shootDirection = Vector2.right;
		}

		protected override void Update()
		{
			Mover.Move(move);
			UpdateAnimator();


		}

		void Move(InputAction.CallbackContext context)
		{
			move = context.ReadValue<Vector2>();
			
			
		}

		void Jump(InputAction.CallbackContext context)
		{
			
			Mover.Jump(jumpHeight);
			animator.SetTrigger("Jump");
		}

		void Shoot(InputAction.CallbackContext context)
		{

			Fire(shootDirection);
			animator.SetTrigger("Throw");
		}

		private void Fire(Vector2 direction)
		{
			Bomb bomb =
				Instantiate(bombPrefab, transform.position, Quaternion.identity);

			bomb.Launch(direction);
		}


		private void UpdateAnimator()
		{
			if (rigidbody.velocity.x < -1)
			{
				renderer.flipX = true;
				shootDirection = Vector2.left;
				animator.SetInteger("Run", 1);

			}
			else if (rigidbody.velocity.x > 1)
			{
				renderer.flipX = false;
				shootDirection = Vector2.right;
				animator.SetInteger("Run", 1);
			}
			else
				animator.SetInteger("Run", 0);
		}



		private void OnDisable()
		{
			inputs.Player.Move.Disable();
			inputs.Player.Move.performed -= Move;
			inputs.Player.Move.canceled -= Move;

			inputs.Player.Jump.Disable();
			inputs.Player.Jump.performed -= Jump;

			inputs.Player.Shoot.Disable();
			inputs.Player.Shoot.performed -= Shoot;

		}

		private void OnEnable()
		{
			inputs.Player.Move.Enable();
			inputs.Player.Move.performed += Move;
			inputs.Player.Move.canceled += Move;
			

			inputs.Player.Jump.Enable();
			inputs.Player.Jump.performed += Jump;

			inputs.Player.Shoot.Enable();
			inputs.Player.Shoot.performed += Shoot;

		}
	}
}
