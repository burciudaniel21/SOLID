using UnityEngine;

public class ShapeChanger : MonoBehaviour
{
    [SerializeField] Transform objectTransform;
    public bool isSquare = false;
    public bool isRectangle = false;

    Shape square = new Square();
    Shape rectangle = new Rectangle();

    private void Update()
    {
        // Using Liskov Substitution Principle to change the shape of the GameObject
        if (isSquare) square.ChangeShape(objectTransform);
        if (isRectangle) rectangle.ChangeShape(objectTransform);
    }
}
