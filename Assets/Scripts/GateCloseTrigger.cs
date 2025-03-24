using UnityEngine;

public class GateCloseTrigger : MonoBehaviour
{
    public Animator gateAnimator;
    void OnTriggerEnter(Collider other) {
        gateAnimator.SetTrigger("Close");
    }
}
