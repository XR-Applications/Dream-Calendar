using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSetter : MonoBehaviour
{
    [SerializeField] Transform parentTransform;
    private void Update()
    {
        transform.rotation = parentTransform.rotation;
    }
}
