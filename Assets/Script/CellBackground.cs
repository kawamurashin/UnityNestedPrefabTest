using UnityEngine;
using System.Collections;

public class CellBackground : MonoBehaviour {

    GameObject parentGameObject;
    Vector3 offset;
   
    void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
    }
    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 vector = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        parentGameObject.transform.position = new Vector3(vector.x, vector.y , 0) + offset;
    }
    void OnMouseUp()
    {

    }
    // Use this for initialization
    void Start () {
        parentGameObject = this.transform.parent.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
