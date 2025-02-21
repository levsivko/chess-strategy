using UnityEngine;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour, IPointerMoveHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private bool captured = false;
    [SerializeField] private Vector3 startPos;

    public void Start()
    {
        startPos = transform.position;
    }

    public void MoveToStart()
    {
        transform.position = startPos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        captured = true;
        Debug.Log("down");
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (!captured)
            return;

        Debug.Log($"move {eventData.delta}");

        var pos = gameObject.transform.position;
        pos.x += eventData.delta.x / 100.0f * 5;
        pos.y += eventData.delta.y / 100.0f * 5;
        gameObject.transform.position = pos;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        captured = false;
        Debug.Log("up");
    }
}
