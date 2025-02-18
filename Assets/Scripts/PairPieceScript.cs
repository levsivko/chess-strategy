using UnityEngine;

public class PairPieceScript : MonoBehaviour
{
    [SerializeField] private GameObject piece1;
	[SerializeField] private GameObject piece2;

	public void SwitchBlackWhite()
    {
		piece1.SetActive(!piece1.activeSelf);
		piece2.SetActive(!piece2.activeSelf);
	}
}
