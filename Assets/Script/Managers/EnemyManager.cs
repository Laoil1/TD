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
		LaunchLevel(currentLevel);
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
		var _enemySR = _enemy.GetComponent<SpriteRenderer>();
		_enemySR.sprite = ed.sprite;
		_enemySR.color = ed.color;
		_enemy.GetComponent<Mortal>().lifeMax = ed.lifeMax;
		_enemy.GetComponent<PathFinder>().speed = ed.speed;
		enemys.Add(_enemy);
	}


#endregion

#region  Wave related Stuff


public LevelData currentLevel;

public void LaunchLevel(LevelData level)
{
	StartCoroutine(ILevel(level));
}

public IEnumerator ILevel(LevelData level)
{
	var timer = 0.0f;
	foreach (var wave in level.waves)
	{
		timer = 0.0f;
		while(timer<= wave.timeBeforeWave)
		{
			timer+=Time.deltaTime;
			yield return new WaitForSeconds(Time.deltaTime);
		}
		StartCoroutine(IWave(wave));
	}
	yield break;
}

public IEnumerator IWave(Wave _wave)
{
	var timer = 0.0f;
	foreach (var enemy in _wave.enemyDatas)
	{
		timer = 0.0f;
		CreateEnemy(enemy);

		while(timer<= _wave.timeBetweenEnemys)
		{
			timer+=Time.deltaTime;
			yield return new WaitForSeconds(Time.deltaTime);
		}
	}
	yield break;
}

#endregion


}
