using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructGrid : MonoBehaviour
{
	public float tileSize = 5;
	
	public Vector3 GetTilePosAt(Vector3 globalPos)
	{
		Vector3 localPos = this.transform.position - globalPos;
		
		float discreteX = Mathf.Round(localPos.x / tileSize) * tileSize;
		float discreteZ = Mathf.Round(localPos.z / tileSize) * tileSize;
		Vector3 discretePos = new Vector3(discreteX, localPos.y, discreteZ);

		return this.transform.TransformPoint(discretePos);
	}
}