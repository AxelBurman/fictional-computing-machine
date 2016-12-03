using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour
{

    public float m_ClimbSpeed = 0.5f;

    private Transform m_CurrentInteractCollider;

    private bool m_IsInsideInteractCollider = false;
    private bool m_CanClimb = false;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (m_IsInsideInteractCollider)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                m_CurrentInteractCollider.SendMessage("OnInteract");
            }
        }

        if (m_CanClimb)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.MovePosition(rb.position + Vector2.up * m_ClimbSpeed);
                
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.MovePosition(rb.position + Vector2.down * m_ClimbSpeed);
            }
        }
	}

    void EnterInteract(Transform i_Trans)
    {
        if (m_CurrentInteractCollider != i_Trans)
        {
            m_CurrentInteractCollider = i_Trans;
            m_IsInsideInteractCollider = true;
        }
    }

    void ExitInteract(Transform i_Trans)
    {
        m_CurrentInteractCollider = null;
        m_IsInsideInteractCollider = false;
    }

    void EnterClimb(Transform i_Trans)
    {
        m_CanClimb = true;
        rb.gravityScale = 0;
    }

    void ExitClimb(Transform i_Trans)
    {
        m_CanClimb = false;
        rb.gravityScale = 3;
    }
}
