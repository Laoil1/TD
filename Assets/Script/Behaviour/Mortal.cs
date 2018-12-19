using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortal : MonoBehaviour {

	[System.NonSerialized]
	public int life, lifeMax;

	// Use this for initialization
	private void Start () 
	{
		SetUpLife();
	}
	
	// Update is called once per frame
	private void Update () 
	{
		Updatelife();
	}

	//This set up life at the start
	private void SetUpLife()
	{
		life = lifeMax;
	}

	//Updtate life call check the life of the mortal
	private void Updatelife()
	{
		if(life<=0)
		{
			Die();
		}
	}

	//Die is Called when life reach 0
	private void Die()
	{
		Debug.Log(gameObject.name + " dies");
		EnemyManager.Instance.enemys.Remove(this.gameObject);
	}

}
