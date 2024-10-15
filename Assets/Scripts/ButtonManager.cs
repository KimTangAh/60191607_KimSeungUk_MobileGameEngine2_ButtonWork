using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
    {
        // 각 버튼에 클릭 이벤트 등록
        button1.onClick.AddListener(() => OnButtonClick("Button 1 Clicked!"));
        button2.onClick.AddListener(() => OnButtonClick("Button 2 Clicked!"));
        button3.onClick.AddListener(() => OnButtonClick("Button 3 Clicked!"));
    }

    void OnButtonClick(string message)
    {
        Debug.Log(message); // 클릭 시 다른 메시지 출력
    }
}