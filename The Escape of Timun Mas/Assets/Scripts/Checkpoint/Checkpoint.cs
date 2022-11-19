using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public Transform[] checkpoints;
    public Transform player;

    public ScriptableValue index;
    
    //panggil di button
    public void SetPlayerToCheckpoint()
    {
        StartCoroutine(SetPosition());
    }

    public void SetCheckpoint(int _index)
    {
        index.value = _index;
    }

    IEnumerator SetPosition()
    {
        player.gameObject.GetComponent<ThirdPersonController>().enabled = false;
        player.position = checkpoints[index.value].position;
        yield return new WaitForSeconds(.1f);
        player.gameObject.GetComponent<ThirdPersonController>().enabled = true;
    }
}
