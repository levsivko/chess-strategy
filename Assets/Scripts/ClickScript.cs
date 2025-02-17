using UnityEngine;
using UnityEngine.EventSystems;

public class ClickScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum State
    {
        Normal,
        Good,
        Bad
    }

    [SerializeField] private State state = State.Normal;
	[SerializeField] private Color startColor;

    public void Start()
    {
        startColor = GetComponent<SpriteRenderer>().color;
	}

    public void ChangeState(State newState)
    {
        if (state == newState)
        {
            state = State.Normal;
        }
        else state = newState;
        UpdateColor();
	}

	public void ResetState()
	{
     	state = State.Normal;		
		UpdateColor();
	}

	public void UpdateColor()
    {

        switch (state)
        {
            case State.Normal:
                {
                    GetComponent<SpriteRenderer>().color = startColor;
                    break;
                }
			case State.Bad:
                {
                    GetComponent<SpriteRenderer>().color = new Color(0.8f, 0, 0);
                    break;
                }
			case State.Good:
                {
                    GetComponent<SpriteRenderer>().color = new Color(0, 0.7f, 0);
					break;
                }
		}
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            ChangeState(State.Good);
		}
        else if (eventData.button == PointerEventData.InputButton.Left)
        {
			ChangeState(State.Bad);
		}
	}

	public void OnPointerUp(PointerEventData eventData)
    {
        
    }
}
