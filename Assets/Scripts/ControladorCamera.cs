using UnityEngine;

public class ControladorCamera : MonoBehaviour
{

    public Transform player;

    private Vector3 offset;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        offset = player.position - startPosition;
    }

    void Update()
    {
        Vector3 newPosition = player.position - Vector3.right * offset.x;
        newPosition.y = startPosition.y;
        newPosition.z = -10f;
        transform.position = newPosition;
    }

}
