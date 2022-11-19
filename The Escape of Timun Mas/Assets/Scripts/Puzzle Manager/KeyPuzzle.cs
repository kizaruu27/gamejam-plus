using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPuzzle : MonoBehaviour
{

    public GameObject Keys;
    public GameObject Door;

    private bool _getKey;



    private void OnTriggerStay(Collider other) {


        if(other.CompareTag("Keys")&&Input.GetKey(KeyCode.F)){
            Keys.SetActive(false);
            _getKey = true;
        }

        if(other.CompareTag("Interactable") && _getKey == true){
            Door.SetActive(false);
        }
    }

}
