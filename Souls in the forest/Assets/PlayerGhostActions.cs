using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class PlayerGhostActions : MonoBehaviour
{
    public bool m_Active = false;
    public GameObject m_Player;
    private Rigidbody2D m_rb;
    private SpriteRenderer m_sr;

    public float m_MaxSpeed = 10;
	// Use this for initialization
	void Start ()
    {
        Debug.Log("start");

        Debug.Log(m_rb);
        Debug.Log(m_Player);

        //m_Player = GameState.Singleton.GetPlayer();
        m_rb = GetComponent<Rigidbody2D>();
        m_sr = GetComponent<SpriteRenderer>();

        Debug.Log(m_rb);
        Debug.Log(m_Player);

        m_sr.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(!m_Active)
        {
            m_rb.MovePosition(m_Player.transform.position);
        }
        else
        {
            m_rb.velocity = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal") * m_MaxSpeed, m_rb.velocity.y);
        }
	}

    void ActivateGhost()
    {
        m_Active = true;
        m_sr.enabled = true;

        m_rb.MovePosition(new Vector2(m_Player.transform.position.x + 1.0f, m_Player.transform.position.y));
    }

    void DeactivateGhost()
    {
        m_Active = false;
        m_sr.enabled = false;
    }
}
