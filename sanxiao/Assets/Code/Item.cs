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
     

    // Use this for initialization
    void Start () {
        int randomnum = (int)Random.Range(0, 8);
        Sprrenderer.sprite = items[randomnum];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
