using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUIManager : MonoBehaviour
{
    // Start 버튼 클릭 시 호출되는 함수
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
