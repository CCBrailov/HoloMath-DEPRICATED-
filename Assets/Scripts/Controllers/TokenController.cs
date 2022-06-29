using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TokenController : MonoBehaviour
{
    public Token token;
    public TextMeshPro textMesh;
    public ExpressionController expressionController;

    public void Expand()
    {
        token.Expand();
        expressionController.BuildTokenControllers();
        Destroy(gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textMesh.SetText(token.displayString);
        gameObject.name = token.displayString;
    }
}