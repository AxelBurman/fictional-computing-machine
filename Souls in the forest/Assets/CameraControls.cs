using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {

    private Transform m_Camera;
    public float m_CameraOffsettY = 0;
    // Use this for initialization
    void Start ()
    {
        m_Camera = GameObject.Find("Main Camera").transform;

    }
	
	// Update is called once per frame
	void Update ()
    {
        m_Camera.position = new Vector3(transform.position.x, transform.position.y + m_CameraOffsettY, -10.0f);
    }
}
