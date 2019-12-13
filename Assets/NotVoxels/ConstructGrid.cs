using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructGrid : MonoBehaviour
{
	
	
	public ConstructTile GetTileAt(Vector3 globalPos)
	{
		Vector3 localPos = this.transform.position - globalPos;
		return null;
	}
}