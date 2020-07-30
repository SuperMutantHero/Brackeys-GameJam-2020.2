using UnityEngine;
using System;
using System.Collections.Generic;

//b48f654f-d0da-4848-9164-f714b574b271
//b48f654f-d0da-4848-9164-f714b574b271

public class RewindManager : MonoBehaviour
{
	public List<float> x_positions;
	public List<float> y_positions;

	public float timeToStore;

	void Start()
	{
		InvokeRepeating("StorePositions", 0, timeToStore);
	}

	public void StorePositions()
	{
		if (x_positions.Count >= 1)
		{
			if (Mathf.Abs(x_positions[x_positions.Count - 1] - transform.position.x) > 0.01f)
			{
				float position = (float)Math.Round(transform.position.x, 3);
				x_positions.Add(position);
			}
		}
		else {

			float position = (float)Math.Round(transform.position.x, 3);
			x_positions.Add(position);
		}

	}
}
