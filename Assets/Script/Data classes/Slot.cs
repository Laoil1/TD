using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

	public Transform self;
	public GameObject spawnedPrefab;
	public bool occupied;

	private void Start()
	{
		self = transform;
		TowerManager.instance.slots.Add(this);
	}

	private void OnMouseDown()
	{
		if (occupied) return;

		TowerManager.instance.SlotClicked(this);
	}

}
