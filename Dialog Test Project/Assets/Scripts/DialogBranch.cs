using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[CreateAssetMenu(fileName = "New Dialog Branch", menuName ="Dialog/New Branch")]
public class DialogBranch : ScriptableObject
{
    public string dialogString;
    public string optionOneString;
    public string optionTwoString;
    public string optionThreeString;

    public DialogBranch optionOneBranch;
    public DialogBranch optionTwoBranch;
    public DialogBranch optionThreeBranch;
}
