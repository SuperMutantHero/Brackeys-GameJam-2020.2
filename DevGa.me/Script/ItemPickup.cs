using UnityEngine;

public class ItemPickup : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D Col)
	{
		if (Col.CompareTag("Collectible"))
		{
			Destroy(gameObject);
		}
	}
}
