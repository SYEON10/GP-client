using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UI_CharacterManaging : UI_Popup
{
    private GameObject pollutionPopup;
    enum Buttons
    {
        BackButton,
        Character1,
        Character2,
        Character3,
        Character4,
        Skill1, Skill2, Skill3, Skill4, Skill5,
        PollutionClearButton,
        PollutionPopupCancle, PollutionPopupAccept
    }

    private void Start()
    {
        pollutionPopup = GameObject.Find("PollutionPopup");
        Init();
        pollutionPopup.SetActive(false);
    }

    public override void Init()
    {
        base.Init();
        Bind<Button>(typeof(Buttons));

        GetButton((int)Buttons.BackButton).gameObject.BindUIEvent(BackButtonClicked);
        GetButton((int)Buttons.Character1).gameObject.BindUIEvent(CharacterButtonClicked);
        GetButton((int)Buttons.Character2).gameObject.BindUIEvent(CharacterButtonClicked);
        GetButton((int)Buttons.Character3).gameObject.BindUIEvent(CharacterButtonClicked);
        GetButton((int)Buttons.Character4).gameObject.BindUIEvent(CharacterButtonClicked);
        GetButton((int)Buttons.Skill1).gameObject.BindUIEvent(SkillButtonClicked);
        GetButton((int)Buttons.Skill2).gameObject.BindUIEvent(SkillButtonClicked);
        GetButton((int)Buttons.Skill3).gameObject.BindUIEvent(SkillButtonClicked);
        GetButton((int)Buttons.Skill4).gameObject.BindUIEvent(SkillButtonClicked);
        GetButton((int)Buttons.Skill5).gameObject.BindUIEvent(SkillButtonClicked);
        GetButton((int)Buttons.PollutionClearButton).gameObject.BindUIEvent(PollutionClearButtonClicked);
        GetButton((int)Buttons.PollutionPopupCancle).gameObject.BindUIEvent(PollutionPopupCancleClicked);
        GetButton((int)Buttons.PollutionPopupAccept).gameObject.BindUIEvent(PollutionPopupAcceptClicked);

    }
    public void BackButtonClicked(PointerEventData eventData)
    {
        Debug.Log("BackButton Clicked");
        SceneManager.LoadScene("MainRoom");
    }
    public void CharacterButtonClicked(PointerEventData eventData)
    {
        Debug.Log("CharacterButton Clicked");
    }
    public void SkillButtonClicked(PointerEventData eventData)
    {
        Debug.Log("SkillButton Clicked");
        SceneManager.LoadScene("SkillManaging");
    }
    public void PollutionClearButtonClicked(PointerEventData eventData)
    {
        Debug.Log("PollutionClearButton Clicked");
        pollutionPopup.SetActive(true);
    }
    public void PollutionPopupCancleClicked(PointerEventData eventData)
    {
        Debug.Log("PollutionPopupCancle Clicked");
        pollutionPopup.SetActive(false);
    }
    public void PollutionPopupAcceptClicked(PointerEventData eventData)
    {
        Debug.Log("PollutionPopupAccept Clicked");
        pollutionPopup.SetActive(false);
    }
}
