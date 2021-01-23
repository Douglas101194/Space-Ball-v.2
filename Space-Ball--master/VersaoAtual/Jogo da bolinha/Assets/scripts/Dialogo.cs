using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    public GameObject painelDialogo;
    public TextAsset arquivo;
    public string[] texto;
    public Text textoDialgo;

    private int fimDaLinha;
    private int linhaAtual;
    public bool ativo;
    public PauseScript pause;

    // Start is called before the first frame update
    void Start()
    {
        if(arquivo != null)
        {
            texto = (arquivo.text.Split('\n'));
        }

        if (fimDaLinha == 0)
        {
            fimDaLinha = texto.Length;
        }
        Desabilitar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Habilitar(int fase)
    {
        if (linhaAtual == (fase-1))
        {
            painelDialogo.SetActive(true);
            textoDialgo.text = texto[linhaAtual];
            linhaAtual += 1;
            pause.pauseGame();
        }
    }

    public void Desabilitar()
    {
        painelDialogo.SetActive(false);
    }

    public void Continuar()
    {
        Desabilitar();
        pause.pauseGame();
    }
}
