using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leftovers_2DPlatformer
{
    public class CameraFollow : MonoBehaviour
    {
		[SerializeField]
		private Transform player;

		[SerializeField]
		private float smoothTime;

		private Vector3 velocity;
		private Vector3 offset;

		private void Start()
		{
			

			Camera camera = GetComponent<Camera>();
			if (camera != null)
			{
				offset = transform.position - player.transform.position;
			}

			offset = new Vector3(0, 1, -10);
		}


		// Update is called once per frame
		void Update()
		{
			
			if (player == null) return;

			Vector3 targetPosition = player.transform.position + offset;

			transform.position = Vector3.SmoothDamp(transform.position, targetPosition,
				ref velocity, smoothTime * Time.deltaTime);

			
		}
	}
}
