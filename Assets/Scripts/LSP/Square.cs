using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    public override void ChangeShape(Transform transform)
    {
        // Change the scale to simulate a square
        transform.localScale = new Vector3(2, 2, 2);
    }
}
