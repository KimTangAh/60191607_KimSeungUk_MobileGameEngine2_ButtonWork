using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
    {
        // �� ��ư�� Ŭ�� �̺�Ʈ ���
        button1.onClick.AddListener(() => OnButtonClick("Button 1 Clicked!"));
        button2.onClick.AddListener(() => OnButtonClick("Button 2 Clicked!"));
        button3.onClick.AddListener(() => OnButtonClick("Button 3 Clicked!"));
    }

    void OnButtonClick(string message)
    {
        Debug.Log(message); // Ŭ�� �� �ٸ� �޽��� ���
    }
}