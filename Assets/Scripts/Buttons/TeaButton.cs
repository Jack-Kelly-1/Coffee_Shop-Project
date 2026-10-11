using UnityEngine;

public class TeaButton : MonoBehaviour
{
    [SerializeField] private OrderingSystem teaOrder;

    void Start()
    {

    }

    public void Tea(int number)
    {
        if (teaOrder.coffeeName == 1)
        {
            Debug.Log("Thank you!");
        }
        else
        {
            Debug.Log("That's not what I ordered");
        }
        teaOrder.customersRemaining = teaOrder.customersRemaining - 1;
    }
}
