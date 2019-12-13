using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ConstructGrid grid;
    Camera thisCamera;
    
    void Awake()
    {
        thisCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = thisCamera.ScreenPointToRay(Input.mousePosition);
        
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 test = grid.GetTilePosAt(hit.point);
                Debug.DrawRay(test, Vector3.up, Color.green, 10);
            }
        }
    }
}
