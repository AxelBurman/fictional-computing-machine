using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public static GameState Singleton = null;
	// Use this for initialization
	void Start () 
	{
		Singleton = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	GameObject GetPlayer()
	{
		return gameObject;
	}
}
