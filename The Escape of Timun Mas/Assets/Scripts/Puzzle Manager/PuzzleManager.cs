using UnityEngine;
using UnityEngine.Events;

public class PuzzleManager : MonoBehaviour
{
    public string collisionTargetName;
    public UnityEvent OnCorrectPuzzle;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == collisionTargetName)
            OnCorrectPuzzle.Invoke();
    }
}
