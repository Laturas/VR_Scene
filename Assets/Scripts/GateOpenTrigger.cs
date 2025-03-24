using UnityEngine;

public class GateOpenTrigger : MonoBehaviour
{
    public Animator gateAnimator;
    void OnTriggerEnter(Collider other) {
        gateAnimator.SetTrigger("Open");
    }
}
