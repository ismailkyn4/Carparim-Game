using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    void Start()
    {
        menuPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        menuPanel.GetComponent<RectTransform>().DOScale(1, 1.5f).SetEase(Ease.OutBack);
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    public void SettingChoose()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
