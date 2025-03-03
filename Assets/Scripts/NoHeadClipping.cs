using UnityEngine;

public class NoHeadClipping : MonoBehaviour
{
    private CharacterController charCon;
    [SerializeField] private Transform camTransform;
    void Start() => charCon = GetComponent<CharacterController>();

    void Update()
    {
        Vector3 currentPos = charCon.center;
        charCon.center = new Vector3(camTransform.position.x, currentPos.y, camTransform.position.z);
        charCon.Move(Vector3.zero);
    }
}
