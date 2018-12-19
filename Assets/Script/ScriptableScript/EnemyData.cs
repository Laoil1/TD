using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Enemy",menuName="TD/Enemy",order=2)]
public class EnemyData : ScriptableObject 
{
	public int lifeMax;
	public Sprite sprite;
	public Color color;

}
