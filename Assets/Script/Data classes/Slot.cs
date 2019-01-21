using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

	public GameObject slotObject;
	public Transform showRange;
	public bool occupied;

	private void Start()
	{
		TowerManager.instance.slots.Add(this);
	}

	private void OnMouseDown()
	{
		CallObjectOnSlot();
	}
	private void OnMouseOver()
	{
		if(occupied) return;
		showRange.localScale = Vector3.one * TowerManager.instance.actualTowerData.range;
		showRange.gameObject.SetActive(true);
	}
	private void OnMouseExit()
	{
		if(occupied) return;
		showRange.gameObject.SetActive(false);
	}
	private void CallObjectOnSlot ()
	{
		if (occupied) return;

		TowerManager.instance.SlotClicked(slotObject);
		occupied = true;

	}

}
