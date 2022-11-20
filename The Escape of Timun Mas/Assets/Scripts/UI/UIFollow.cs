using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollow : MonoBehaviour
{
    [SerializeField] Transform targetPlayer;
    [SerializeField] Vector3 offset = new Vector3();

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Camera.main.WorldToScreenPoint(targetPlayer.position + offset);
    }
}
