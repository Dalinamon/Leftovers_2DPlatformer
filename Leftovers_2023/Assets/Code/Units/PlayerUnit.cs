using Leftovers_2DPlatformer.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Leftovers_2DPlatformer
{
    public class PlayerUnit : UnitBase
    {
		// Inputs
		private Inputs inputs;
		
		private Vector2 move;

		[SerializeField]
		private float jumpHeight;


		protected override void Awake()
		{
			base.Awake();

			inputs = new Inputs();
		}

		protected override void Start()
		{
			base.Start();

			
		}

		protected override void Update()
		{
			Mover.Move(move);
		}

		void Move(InputAction.CallbackContext context)
		{
			move = context.ReadValue<Vector2>();
		}

		void Jump(InputAction.CallbackContext context)
		{
			
			Mover.Jump(jumpHeight);
		}

		private void OnDisable()
		{
			inputs.Player.Move.Disable();
			inputs.Player.Move.performed -= Move;
			inputs.Player.Move.canceled -= Move;

			inputs.Player.Jump.Disable();
			inputs.Player.Jump.performed -= Jump;
			
		}

		private void OnEnable()
		{
			inputs.Player.Move.Enable();
			inputs.Player.Move.performed += Move;
			inputs.Player.Move.canceled += Move;

			inputs.Player.Jump.Enable();
			inputs.Player.Jump.performed += Jump;
			
		}
	}
}
