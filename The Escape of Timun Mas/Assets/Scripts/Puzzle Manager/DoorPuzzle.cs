using UnityEngine;


//script ini bakal diubah2, sekarang cuma dummy aja
public class DoorPuzzle : MonoBehaviour
{
   public GameObject doorObject;
   KeyPuzzle _keyPuzz;
   
   private void Start() {
      _keyPuzz = FindObjectOfType<KeyPuzzle>();
   }

   public void OpenDoor()
   {
      doorObject.SetActive(false);
   }

}
