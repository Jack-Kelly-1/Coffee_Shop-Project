using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.EventSystems;

public class Customer : MonoBehaviour
{
    [SerializeField] private OrderingSystem customerRemaining;

    void Start()
    {

         GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
         cube.transform.position = new Vector3(0, 1, 0);

    }

}
