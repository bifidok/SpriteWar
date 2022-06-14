using UnityEngine;
using UnityEngine.UI;

public class UIMoney : MonoBehaviour
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    public void ChangeValue(int money)
    {
        _text.text = money.ToString();
    }
}
