using UnityEngine;
using System.Collections;
public enum Wannum
{
    w1,
    w2,
    w3,
    w4,
    w5,
    w6,
    w7,
    w8,
    w9

}
public enum ItemType
{
    NONE = 0,
    VERTICAL_STRIPPED,
    HORIZONTAL_STRIPPED,
    PACKAGE,
    BOMB,
    INGREDIENT
}
public class Item : MonoBehaviour {
 
   private Wannum wannum = Wannum.w1;
    public SpriteRenderer Sprrenderer;
    public Sprite[] items;
    public Sprite[] packageItems;
    public Sprite[] bombItems;
    public Sprite[] ingredientItems;
    public Vector3 dragpos;
    public bool Isdrag = false;
    // Use this for initialization
    void Start () {
        int randomnum = (int)Random.Range(0, 8);
        Sprrenderer.sprite = items[randomnum];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void CheckDrag()
    {
        if (Isdrag)
        {
            Vector3 DelPos = dragpos - Input.mousePosition;
            if (Vector3.Magnitude(DelPos) > 0.1f)
            {
                if (Mathf.Abs(DelPos.x) > Mathf.Abs(DelPos.y) && DelPos.x > 0)
                    Debug.Log("zuo");
                else if (Mathf.Abs(DelPos.x) > Mathf.Abs(DelPos.y) && DelPos.x < 0)
                    Debug.Log("you");
                else if (Mathf.Abs(DelPos.x) < Mathf.Abs(DelPos.y) && DelPos.y > 0)
                    Debug.Log("shang");
                else if (Mathf.Abs(DelPos.x) < Mathf.Abs(DelPos.y) && DelPos.y < 0)
                    Debug.Log("xia");
            }

        }
    }
    IEnumerator ExChange()
    {
        yield return 0;
    }
    public Item switchItem;
    public squre neighborSquare;
    void ResetDrag()
    {
        Isdrag = false;
        neighborSquare = null;
        switchItem = null;
    }
}
