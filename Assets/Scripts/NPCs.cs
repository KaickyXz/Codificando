using UnityEditor;
using UnityEngine;

public class NPCs : MonoBehaviour
{
    public string nome;
    public bool estuda;
    public int dinheiro;

    private void Start()
    {
        NPCs thifas = new NPCs();
        thifas.nome = "thifas";
        thifas.estuda = false;
        thifas.dinheiro = 7;

        NPCs joana = new NPCs();
        joana.nome = "joana";
        joana.estuda = true;
        joana.dinheiro = 67;

        NPCs gregorus = new NPCs();
        gregorus.nome = "gregorus";
        gregorus.estuda = true;
        gregorus.dinheiro = 35;
    }


}