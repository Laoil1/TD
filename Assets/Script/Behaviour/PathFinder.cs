using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour {

	public Transform self;
	private Transform[] path;

	[System.NonSerialized]
	public float speed = 15;
	private float lerpProgression;
	private bool nodeReached;

	// Use this for initialization
	void Start () 
	{
		path = EnemyManager.Instance.pathNodes;
		speed = 16-speed;
		StartCoroutine(PathFind());
	}

	private IEnumerator PathFind()
	{
		for (int i = 0; i < path.Length-1; i++)
		{
			while (!nodeReached)
			{
				nodeReached = GoToPath(path[i].position,path[i+1].position);
				yield return new WaitForSeconds(Time.deltaTime/speed);
			}
			nodeReached = false;
		}

		yield break;
	}

	private bool GoToPath(Vector3 exPath, Vector3 targPath)
	{
		self.position = Vector3.Lerp (exPath,targPath,lerpProgression);
		if(lerpProgression>=1.0f)
		{
			lerpProgression = 0.0f;
			return true;
		}
		lerpProgression += 0.1f/speed;
		return false;
	}
}
