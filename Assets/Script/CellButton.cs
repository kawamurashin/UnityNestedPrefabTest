using UnityEngine;
using System.Collections;

public class CellButton : MonoBehaviour {
    public delegate void CallBack();
    private CallBack mouseDownCallBack;
    private CallBack mouseDragCallBack;
    private CallBack mouseUPCallBack;
    public void addMouseDown(CallBack callback)
    {
        mouseDownCallBack += callback;
    }
    public void addMouseDrag(CallBack callback)
    {
        mouseDragCallBack += callback;
    }
    public void addMouseUp(CallBack callback)
    {
        mouseUPCallBack += callback;
    }
    void OnMouseDown()
    {
       mouseDownCallBack();
    }
    void OnMouseDrag()
    {
        
    }
    void OnMouseUp()
    {
        
    }
   
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
