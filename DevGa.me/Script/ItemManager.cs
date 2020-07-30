﻿using UnityEngine;

public class ItemManager : MonoBehaviour
{
	/// <summary>
	/// This script sits on the player
	/// </summary>

	public void AddItem(ItemTypes item)
	{
		if (item == ItemTypes.SimpleGun)
		{
			EnableSimpleGun();
		}
		else if (item == ItemTypes.ComplexGun)
		{
			EnableComplexGun();
		}
	}

	void EnableSimpleGun()
	{
		print("Simple Gun enabled");
	}

	void EnableComplexGun()
	{
		print("Complex Gun activated");
	}
}
