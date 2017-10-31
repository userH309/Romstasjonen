using UnityEngine;
using System.Collections;

public class layerTrigger : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D other)
	{
		var layerArray = GameObject.FindGameObjectsWithTag("objects");
		Debug.Log ("bak");

		foreach(GameObject n in layerArray)
		{
			var layer = n.GetComponent<SpriteRenderer>();
			layer.sortingOrder = 3;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		var layerArray = GameObject.FindGameObjectsWithTag("objects");
		Debug.Log ("forann");

		foreach(GameObject n in layerArray)
		{
			var layer = n.GetComponent<SpriteRenderer>();
			layer.sortingOrder = 1;
		}
	}
}
