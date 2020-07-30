using UnityEngine;

public enum ItemTypes
{
	SimpleGun,
	ComplexGun
}

public class Item : MonoBehaviour
{

	/// <summary>
	/// This script sits on the item
	/// Please specify the details
	/// </summary>

	public string itemName;
	public ItemTypes itemType;

	void OnTriggerEnter2D(Collider2D Col)
	{
		if (Col.CompareTag("Player"))
		{

			ItemManager playerItemManager = Col.gameObject.GetComponent<ItemManager>();
			playerItemManager.AddItem(itemType);

			Destroy(gameObject);
		}
	}
}
