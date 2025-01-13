using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileStates states { get; private set; }
    public TileCell cell { get; private set; }
    public int number {  get; private set; }

}
