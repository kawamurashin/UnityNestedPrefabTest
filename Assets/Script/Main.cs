using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int i = 0;
        int n = 0;
        Cell cell;
        //

        //
        n = 5;
        for(i=0;i<n;i++)
        {
            GameObject gameObject = Instantiate(Resources.Load("prefab/Cell")) as GameObject;
            gameObject.transform.position = new Vector3(-3.0f, -3.0f +1.2f * i, 0);
            cell = gameObject.GetComponent<Cell>();
            cell.setLable("Cell " + i);
        }
        


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
