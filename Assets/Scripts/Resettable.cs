using UnityEngine;
using UnityEngine.Events;

// Allows objects to reset when game restarts.
public class Resettable : MonoBehaviour {
    public UnityEvent onReset;

    public void Reset() {
        onReset.Invoke();
    }
}
