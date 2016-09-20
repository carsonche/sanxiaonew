using UnityEngine;
using System.Collections;
public enum SquareTypes
{
    NONE = 0,
    EMPTY,
    BLOCK,

}
public class squre : MonoBehaviour {
    public int Row;
    public int Col;
    public Item item;
    public SquareTypes type;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
