using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SecondMenuManager : MonoBehaviour
{
    [SerializeField] GameObject secondMenuPanel;
    void Start()
    {
        secondMenuPanel.GetComponent<CanvasGroup>().DOFade(1,1f);
        secondMenuPanel.GetComponent<RectTransform>().DOScale(1, 1.3f).SetEase(Ease.OutBack); 
    }
    public void WhichGameOpen(string whichGame)
    {
        PlayerPrefs.SetString("whichgame", whichGame);
        SceneManager.LoadScene("GameLevel");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MenuLevel");
    }
}
