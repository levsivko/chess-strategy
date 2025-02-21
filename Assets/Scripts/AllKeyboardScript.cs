using UnityEngine;
using UnityEngine.EventSystems;

public class AllKeyboardScript : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
			ClickScript[] objects = (ClickScript[])GameObject.FindObjectsByType(typeof(ClickScript), FindObjectsSortMode.None);
            foreach (var o in objects) {
                o.ResetState();
            }
        }

		if (Input.GetKeyDown(KeyCode.F1))
		{
			{
				PieceScript[] objects = (PieceScript[])GameObject.FindObjectsByType(typeof(PieceScript), FindObjectsInactive.Include, FindObjectsSortMode.None);
				foreach (var o in objects)
				{
					o.SwitchBlackWhite();
				}
			}

			{
				PairPieceScript[] objects = (PairPieceScript[])GameObject.FindObjectsByType(typeof(PairPieceScript), FindObjectsInactive.Include, FindObjectsSortMode.None);
				foreach (var o in objects)
				{
					o.SwitchBlackWhite();
				}
			}

            {
                MoveScript[] objects = (MoveScript[])GameObject.FindObjectsByType(typeof(MoveScript), FindObjectsInactive.Include, FindObjectsSortMode.None);
                foreach (var o in objects)
                {
                    o.MoveToStart();
                }
            }
        }
	}
}
