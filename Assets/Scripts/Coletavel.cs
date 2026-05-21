using UnityEngine;

public class Coletavel : MonoBehaviour
{

    public string nomeMoeda;
    public int valorMoeda;
    public bool podePegar;

    public void Pegarmoeda()
    {
        Debug.Log("Você pegou uma moeda de " + nomeMoeda + ".");
    }
}
