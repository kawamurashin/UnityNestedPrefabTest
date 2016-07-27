using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cell : MonoBehaviour {
    TextMesh textMesh;
    int count = 0;
	// Use this for initialization
    void Awake()
    {
        Transform child = this.transform.FindChild("New Text");
        textMesh = (TextMesh)child.GetComponent(typeof(TextMesh));
    }
    public void setLable(string value)
    {
        textMesh.text = value;
    }
	void Start () {
        Transform child;

        child = this.transform.FindChild("CellBackground");
        CellBackground cellbackground = (CellBackground)child.GetComponent("CellBackground");

        child = this.transform.FindChild("CellButton");
        CellButton cellButton = (CellButton)child.GetComponent("CellButton");
        cellButton.addMouseDown(mouseDownHandler);
    }
	
	// Update is called once per frame
	void Update () {

         
    }
    void mouseDownHandler()
    {
        count++;
        textMesh.text = count.ToString();
    }
}
