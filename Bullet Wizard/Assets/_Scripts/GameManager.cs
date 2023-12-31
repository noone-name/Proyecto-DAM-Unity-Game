﻿using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorTexture = null;

    private void Start()
    {
        SetCursorIcon();
    }

    private void SetCursorIcon()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(cursorTexture.width / 2f, cursorTexture.height / 2f), CursorMode.Auto);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        DOTween.KillAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void PauseMenu()
    {
        Time.timeScale = 0f;
    }


    public void ResumeButton()
    {
        Time.timeScale = 1f;
    }

    public void toMenuPrincipal()
    {
        Time.timeScale = 1f;
        DOTween.KillAll();
        SceneManager.LoadScene("GameSceneStart");
    }



}
