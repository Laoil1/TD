using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour {

	public static TowerManager instance;
	
	public List<Slot> slots = new List<Slot>();

	// Use this for initialization
	void Awake () {
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(this);
		}
	}

	public void SlotClicked(Slot _slot)
	{
		Instantiate(_slot.spawnedPrefab, _slot.self.position, Quaternion.identity, _slot.self);
	}
}
