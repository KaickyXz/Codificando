using UnityEditor;
using UnityEngine;

public class NPCs : MonoBehaviour
{
    public string nome;
    public bool estuda;
    public int dinheiro;

    private void Start()
    {

    }

    public void Nome()
    {
        Debug.Log("Oi meu nome é: " + nome + " e tenho " + dinheiro + " coins.");
    }

}