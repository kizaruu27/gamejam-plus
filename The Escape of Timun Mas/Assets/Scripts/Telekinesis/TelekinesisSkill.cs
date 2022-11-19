using UnityEngine;

public class TelekinesisSkill : MonoBehaviour
{
    public float transitionSpeed = 5;
    public Transform targetTransform;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable")
        {
            if (Input.GetMouseButton(0))
            {
                other.transform.position = Vector3.Lerp(other.transform.position, targetTransform.position, transitionSpeed * Time.deltaTime);
                other.transform.GetComponent<Rigidbody>().useGravity = false;
                other.transform.GetComponent<BoxCollider>().isTrigger = true;
            }
            else
            {
                other.transform.GetComponent<Rigidbody>().useGravity = true;
                other.transform.GetComponent<BoxCollider>().isTrigger = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            other.transform.GetComponent<Rigidbody>().useGravity = true;
            other.transform.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
