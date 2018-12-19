using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="NewBullet",menuName="TD/Bullet",order=4)]
public class BulletData : ScriptableObject 
{
	public Sprite sprite;
	public int damage;

}
