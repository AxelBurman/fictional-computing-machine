using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public static GameState Singleton = null;
    public Transform m_Camera;
    public float m_CameraOffsettY = 0;
	// Use this for initialization
	void Start () 
	{
		//DontDestroyOnLoad(gameObject);
		Singleton = this;
	}
	
	// Update is called once per frame
	void Update () 
	{
        m_Camera.position =  new Vector3(transform.position.x, transform.position.y + m_CameraOffsettY, -10.0f);

    }

	GameObject GetPlayer()
	{
		return gameObject;
	}
}
