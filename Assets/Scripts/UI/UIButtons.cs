using UnityEngine;
using UnityEngine.Events;

public class UIButtons: MonoBehaviour
{

    public UnityAction<int> buttonClicked;

    public void OnButtonClicked(int unitNumber)
    {
        buttonClicked?.Invoke(unitNumber - 1);
    }
}
