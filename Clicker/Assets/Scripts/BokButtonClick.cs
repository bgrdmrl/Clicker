using UnityEngine;
using TMPro;

public class BokButtonClick : MonoBehaviour
{
    public static float counterMultiplier = 1.0f;

    public TextMeshProUGUI floatingNumbers;

    public void BokButton()
    {
        CounterClick.counter += counterMultiplier;

        floatingNumbers.text = counterMultiplier.ToString();
        TextMeshProUGUI newNumber = Instantiate(floatingNumbers, transform.position, Quaternion.identity);
        newNumber.transform.SetParent(GameObject.FindGameObjectWithTag("bg").transform, false);
    }
}
