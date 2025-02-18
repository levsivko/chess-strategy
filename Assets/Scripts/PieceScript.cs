using UnityEngine;

public class PieceScript : MonoBehaviour
{
    public void SwitchBlackWhite()
    {
        var color = GetComponent<SpriteRenderer>().color;
        if (color == Color.black)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
			GetComponent<SpriteRenderer>().color = Color.black;
		}
	}
}
