using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Dialog", menuName ="Dialog/New Dialog")]
public class Dialog : ScriptableObject
{

    [SerializeField] private DialogBranch[] branches;
    public DialogBranch currentBranch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
