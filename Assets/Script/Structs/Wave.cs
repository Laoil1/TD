using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Wave 
{
	public float timeBeforeWave;
	public float timeBetweenEnemys;
	public int difficulty;
	public EnemyData[] enemyDatas;
}
