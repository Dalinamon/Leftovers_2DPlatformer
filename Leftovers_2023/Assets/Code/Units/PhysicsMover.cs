using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PhysicsMover : MonoBehaviour, IMove
    {
		private new Rigidbody2D rigidbody;
		private Vector2 movement;

		private float gravityMultiplier = 2.5f;

		public float Speed
		{
			get;
			private set;
		}

		public void MovementSpeed(float speed)
		{
			Speed = speed;
		}

		private void Awake()
        {
			rigidbody = GetComponent<Rigidbody2D>();
			if (rigidbody == null)
			{
				Debug.LogError("Rigidbody2D can't be found!");
			}
		}
        private void Update()
        {
            
        }

        private void FixedUpdate()
		{
			rigidbody.velocity = new Vector2(movement.x * Speed, rigidbody.velocity.y);

			if (rigidbody.velocity.y < 0)
			{
				rigidbody.velocity += Vector2.up * Physics.gravity.y * gravityMultiplier * Time.deltaTime;

			}

		}

		public void Move(Vector2 direction)
		{
			movement = direction;
		}

		public void Jump(float height)
		{
			rigidbody.AddForce(Vector2.up * height, ForceMode2D.Impulse);
		}
	}
}
