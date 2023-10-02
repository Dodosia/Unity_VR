using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_StartButton : MonoBehaviour
{
    public Button button;
    public GameObject character;
    private S_CharacterMovement mov;

    private void Awake()
    {
        mov = character.GetComponent<S_CharacterMovement>();
        mov.enabled = false;
        Time.timeScale = 0f;
    }

    private void OnEnable()
    {
        button.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(StartGame);
    }

    private void StartGame()
    {
        Time.timeScale = 1f;
        mov.enabled = true;

        button.gameObject.SetActive(false);
    }
}
