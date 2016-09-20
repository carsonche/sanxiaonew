using UnityEngine;
using System.Collections;

public class Levelmanger : MonoBehaviour {
    private static Levelmanger instance;
    public GameObject item;
    public GameObject squre;
    public int LevelNUM=1;
    public Transform itemfield;
    void Awake()
    {
      //  itemfield = GameObject.Find("Itemfield").transform;
           instance = this;
    }
	// Use this for initialization
	void Start () {
        Inititems(42);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void Inititems(int num)
    {
        int col=LevelNUM+5;
        int maxrow= num/col;
        for (int i = 0; i <= col- 1; i++)
        {
            for (int j = 0; j <= maxrow- 1; j++)
            {
                GameObject item0 = null;
                Vector3 itemposition = new Vector3(i*0.7f,j*0.9f,0);
                item0 = Instantiate(item, itemfield.position+itemposition, Quaternion.identity)as GameObject;
                item0.transform.parent = itemfield;
                item0.name = i.ToString() + "_" + j.ToString() + "item";
              
            }
        }
         
    }

}
