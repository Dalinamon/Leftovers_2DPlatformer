using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
	public abstract class UnitBase : MonoBehaviour
	{
		[SerializeField]
		private float speed = 5;

		public IMove Mover
		{
			get;
			private set;
		}

		protected virtual void Awake()
		{
			Mover = GetComponent<IMove>();
			if (Mover == null)
			{
				Debug.LogError("Mover is missing!");
			}
		}

		protected virtual void Start()
		{
			Mover.Setup(speed);
		}

		protected abstract void Update();

		protected virtual void Die()
		{
			
		}
	}
}
