using UnityEngine;

public class Level : MonoBehaviour
{
    public int levelNumero;
    public float quantidadeExp;
    public bool podeEvoluir;
    public string nomeLevel;


    public void Evoluir()
    {
        if (podeEvoluir)
        {
            Debug.Log("Level Up! +1 em todos os status.");
        }
        else
        {
            Debug.Log("Desista dos seus sonhos e morra.");
        }
    }
    void Start()
    {
        
    }


}
