using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTest : MonoBehaviour {

		public float gravity = 100.0f;
		public float cutoffDistance = 10.0f;
		public Rigidbody planet;
		public Rigidbody player;

		private Vector3[] m_GravityDirections =
		{
			Vector3.up,
			Vector3.down,
			Vector3.left,
			Vector3.right,
			Vector3.forward,
			Vector3.back
		};

		private float UniversalGravitation(Rigidbody a, Rigidbody b)
		{
			float distance = Vector3.Distance(a.transform.position, b.transform.position);
			if (distance >= cutoffDistance)
				return 0.0f;

			return gravity * (a.mass * b.mass) / distance;
		}

		private Vector3 CubeGravityDirection(Rigidbody planet, Rigidbody other)
		{
			float bestDot = -1.0f;
			Vector3 direction = Vector3.zero;

			for (int index=0; index < m_GravityDirections.Length; index++)
			{
				Vector3 gravityDirection = planet.transform.TransformVector(m_GravityDirections[index]).normalized;
				Vector3 directionToOther = (other.transform.position - planet.transform.position).normalized;

				float dot = Vector3.Dot(gravityDirection, directionToOther);

				if (dot > bestDot)
				{
					direction = gravityDirection;
					bestDot = dot;
				}
			}

			return direction;
		}

		private Vector3 CubeGravityForce(Rigidbody planet, Rigidbody other)
		{
			float gravity = UniversalGravitation(planet, other);
			Vector3 direction = CubeGravityDirection(planet, other);

			return gravity * direction * -1.0f;
		}

		public void FixedUpdate()
		{
			Vector3 gravityForce = CubeGravityForce(planet, player);
			player.AddForce(gravityForce);

			Vector3 up = CubeGravityDirection(planet, player);
		player.transform.rotation = Quaternion.LookRotation (player.transform.forward, up);
		}
	}
