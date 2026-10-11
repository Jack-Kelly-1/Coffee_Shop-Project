using UnityEngine;

public class LatteButton : MonoBehaviour
{
    [SerializeField] private OrderingSystem latteOrder;

    void Start()
    {

    }

    public void Latte(int number)
    {
        if (latteOrder.coffeeName == 2)
        {
            Debug.Log("Thank you!");
        }
        else
        {
            Debug.Log("That's not what I ordered");
        }
        latteOrder.customersRemaining = latteOrder.customersRemaining - 1;
    }
}
