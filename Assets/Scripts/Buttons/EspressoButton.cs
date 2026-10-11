using UnityEngine;

public class EspressoButton : MonoBehaviour
{
    [SerializeField] private OrderingSystem espressoOrder;

    void Start()
    {

    }

    public void Espresso(int number)
    {
        if (espressoOrder.coffeeName == 4)
        {
            Debug.Log("Thank you!");
        }
        else
        {
            Debug.Log("That's not what I ordered");
        }
        espressoOrder.customersRemaining = espressoOrder.customersRemaining - 1;
    }
}
