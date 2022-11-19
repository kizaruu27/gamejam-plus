using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierPlayer : MonoBehaviour
{

    public Transform Player;
    public int zPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, zPosition);
    }
}
