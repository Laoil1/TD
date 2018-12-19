using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	// Use this for initialization
	void Start () {
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(this);
		}
	}
	
	public void Win()
	{
		print("Won!");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Lost()
	{
		print("Lost!");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
