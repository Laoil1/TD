using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

//# Descriptions
// Ce Manager instancie les ennemis en fonction de waves. 
// Ce Manager stock les Nodes de pathfinding et les renvoies aux enemis.


	private void Awake ()
	{
		SingleTonize();
	}

	private void Start ()
	{

	}

	private void Update ()
	{

	}


#region  SingleTone
	public static EnemyManager Instance;

	private void SingleTonize () {
		if(Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(this);
		}
	}

#endregion


#region Path related stuff
	public Transform[] pathNodes;
	private void GetAllNodes ()
	{

	}

#endregion

#region  InstantiateEnemy

	public List<GameObject> enemys;
	public GameObject enemyPrefab;
	private void CreateEnemy (EnemyData ed)
	{
		var _enemy = Instantiate(enemyPrefab);
		_enemy.GetComponent<SpriteRenderer>().sprite = ed.sprite;
		_enemy.GetComponent<Mortal>().lifeMax = ed.lifeMax;
	}


#endregion
}
