using UnityEngine;

public class CappucinoButton : MonoBehaviour
{
    [SerializeField] private OrderingSystem cappucinoOrder;


    public void StartCoffee()
    {

    }
    public void Cappucino(int number)

        {
            if (cappucinoOrder.coffeeName == 3)
            {
                Debug.Log("Thank you!");
            }
            else
            {
                Debug.Log("That's not what I ordered");
            }
            cappucinoOrder.customersRemaining = cappucinoOrder.customersRemaining - 1;
        }
}
