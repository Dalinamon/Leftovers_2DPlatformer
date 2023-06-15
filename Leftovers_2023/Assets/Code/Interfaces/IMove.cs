using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
	public interface IMove
	{
		float Speed { get; }

		void Setup(float speed);
		
		void Move(Vector2 direction);
		
		void Jump(float height);

	}

}
