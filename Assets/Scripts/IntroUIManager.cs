using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUIManager : MonoBehaviour
{
    // Start ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
