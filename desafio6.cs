using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desafio6 : MonoBehaviour
{
    //basado en: https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
    
    //declaro las variables que voy a usar
    public GameObject[] tagTrees;
    public GameObject[] tagBranches;
    public GameObject[] tagGrass;
    
    // Start is called before the first frame update
    void Start()
    {
        //cuando se presiona play, Obtener todos los GameObjects por tag "Tree":
        tagTrees = GameObject.FindGameObjectsWithTag("Trees");

        //Para cada uno de ellos mostrar mensaje en consola usando foreach:
        foreach (GameObject Tree in tagTrees) 
        {
            Debug.Log($"Nombre: {Tree.name}, posicion {Tree.transform.position}");
        }

        //cuando se presiona play, Obtener todos los GameObjects por tag "Branches":
        tagBranches = GameObject.FindGameObjectsWithTag("Branches");

        //Para cada uno de ellos setear su localscale en 10 para todos sus ejes usando for:
        
        // si fuera con foreach:
        /*foreach (GameObject Branch in tagBranches)
        {
            Branch.transform.localScale = new Vector3(10,10,10);
        }*/

        //con for:
        for (int i = 0; i < tagBranches.Length; i++)
        {
            tagBranches[i].transform.localScale = new Vector3(10,10,10);
        }


        //cuando se presiona play, Obtener todos los GameObjects por tag "Grass":
        tagGrass = GameObject.FindGameObjectsWithTag("Grass");
        
        // ocultarlos usando un bucle while
        
        //si fuera con foreach

        /*foreach (GameObject Grass in tagGrass)
        {
            Grass.SetActive(false);
        }*/

        //con un bucle while
        int j = 0;
        while (j < tagGrass.Length)
        {
            tagGrass[j].SetActive(false);
            j++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
