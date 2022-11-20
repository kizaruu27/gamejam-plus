using UnityEngine;

public class KeyPuzzlev2 : MonoBehaviour
{

    public GameObject Keys;
    public GameObject Door;

    private bool _getKey;



    private void OnTriggerStay(Collider other) {


        if(other.CompareTag("Keys")&&Input.GetKey(KeyCode.F)){
            Keys.SetActive(false);
            _getKey = true;
        }

        if(other.CompareTag("Door") && _getKey == true){
            Door.SetActive(false);
        }
    }

}
