using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;

public class OrderingSystem : MonoBehaviour
{

    public int coffeeName = 5;
    public int customersRemaining = 4;
    public void CustomerSpeech(int number)
    {
        if (customersRemaining > 0)
        {
            coffeeName = Random.Range(0, 5);
            if (coffeeName == 1)
            {
                Debug.Log("I would like a Tea please");
            }
            else if (coffeeName == 2)
            {
                Debug.Log("I would like a Latte please");
            }
            else if (coffeeName == 3)
            {
                Debug.Log("I would like a Cappucino please");
            }
            else if (coffeeName == 4)
            {
                Debug.Log("I would like an Espresso please");
            }
        }
        if (customersRemaining == 0)
        {
            Debug.Log("The shop is now closing");
        }
    }
    void Update()
    {

    }

}
