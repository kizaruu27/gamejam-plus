using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPos : MonoBehaviour
{
    public Transform checkpoints;
    private void Start()
    {
        transform.position = checkpoints.position;
    }
}
