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
	}
}
