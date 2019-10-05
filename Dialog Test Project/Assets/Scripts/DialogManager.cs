using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText;
    [SerializeField] private TextMeshProUGUI optionOneText;
    [SerializeField] private TextMeshProUGUI optionTwoText;
    [SerializeField] private TextMeshProUGUI optionThreeText;

    public Dialog currentDialog;
    private DialogBranch currentBranch;

    private void Start()
    {
        ResetOptions();
    }

    void ResetOptions()
    {
        if (currentDialog)
        {
            if (currentDialog.currentBranch)
            {
                currentBranch = currentDialog.currentBranch;
                SetUGUIText(dialogText, currentBranch.dialogString);
                SetUGUIText(optionOneText, currentBranch.optionOneString);
                SetUGUIText(optionTwoText, currentBranch.optionTwoString);
                SetUGUIText(optionThreeText, currentBranch.optionThreeString);
            }
        }
    }

    void SetUGUIText(TextMeshProUGUI tmpro, string text)
    {
        tmpro.text = text;
    }

    public void OptionOnePressed()
    {
        if (currentDialog)
        {
            if (currentBranch)
            {
                if (currentBranch.optionOneString != "")
                {
                    currentDialog.currentBranch = currentBranch.optionOneBranch;
                    
                    ResetOptions();
                }
            }
        }
    }

    public void OptionTwoPressed()
    {
        if (currentDialog)
        {
            if (currentBranch)
            {
                if (currentBranch.optionTwoString != "")
                {
                    currentDialog.currentBranch = currentBranch.optionTwoBranch;
                    ResetOptions();
                }
            }
        }
    }

    public void OptionThreePressed()
    {
        if (currentDialog)
        {
            if (currentBranch)
            {
                if (currentBranch.optionThreeString != "")
                {
                    currentDialog.currentBranch = currentBranch.optionThreeBranch;
                    ResetOptions();
                }
            }
        }
    }
}
