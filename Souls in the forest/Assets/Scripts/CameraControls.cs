using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {

    private Transform m_Camera;
    public float m_CameraOffsettY = 0;

    public Transform m_CameraFocus;
    // Use this for initialization
    void Start ()
    {
        m_Camera = GameObject.Find("Main Camera").transform;
        m_CameraFocus = transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        m_Camera.position = new Vector3(m_CameraFocus.position.x, m_CameraFocus.position.y + m_CameraOffsettY, -10.0f);
    }

    void SetCameraFocus(Transform i_Trans)
    {
        m_CameraFocus = i_Trans;
    }
}
