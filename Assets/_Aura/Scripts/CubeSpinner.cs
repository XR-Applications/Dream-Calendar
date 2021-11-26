
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpinner : MonoBehaviour
{
    float xSpin, ySpin, zSpin;
    [SerializeField]float _spinMultiplier = 20f;

    private void Start()
    {
        RandomizeSpin();
    }

    private void Update()
    {

        transform.Rotate(xSpin * Time.deltaTime, ySpin * Time.deltaTime, zSpin * Time.deltaTime);
    }
    private void RandomizeSpin()
    {
        xSpin = Random.Range(10, 50) * _spinMultiplier;
        ySpin = Random.Range(10, 50) * _spinMultiplier;
        zSpin = Random.Range(10, 50) * _spinMultiplier;
    }
}
