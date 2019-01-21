using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour {

	public static TowerManager instance;
	public List<Slot> slots = new List<Slot>();
	public bool canBuild;

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

	#region  PlaceTower

	public List<GameObject> towers;
	public TowerData actualTowerData;

	public void SlotClicked(GameObject tower)
	{
		var _towerSR = tower.GetComponent<SpriteRenderer>();
		_towerSR.sprite = actualTowerData.sprite;
		_towerSR.color = actualTowerData.color;
		tower.GetComponent<Shooter>().SetRange(actualTowerData.range);
		towers.Add(tower);
	}


#endregion
}
