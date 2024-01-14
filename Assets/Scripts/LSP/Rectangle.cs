using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    public override void ChangeShape(Transform transform)
    {
        // Change the scale to simulate a rectangle
        transform.localScale = new Vector3(2, 2, 1);
    }
}
