using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpin : MonoBehaviour
{
    [SerializeField] float m_SpinMultiplier = 10f;
    private float planetYSpin;
    private void Start()
    {
        planetYSpin = Random.Range(5, 10);
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * planetYSpin * m_SpinMultiplier * Time.deltaTime);
    }
}
