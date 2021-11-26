using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Responsible for turntable effect
/// </summary>
public class WorldSpinner : MonoBehaviour
{
    [SerializeField] float m_TurnSpeed = -10f;

    private void Start()
    {
       
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * m_TurnSpeed * Time.deltaTime);
    }

    public void ActivateWorld()
    {
       
    }

    public void DeactivateWorld()
    {
      
    }
}
