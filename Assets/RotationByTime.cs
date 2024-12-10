using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationByTime : MonoBehaviour
{
    [SerializeField]
    private float factor = 1.0f;

    private Vector3 axis;

    private void Start()
    {
        axis = Vector3.up;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(axis, Time.deltaTime * 10.0f * factor);
    }
}
