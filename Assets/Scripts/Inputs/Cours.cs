using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cours : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        int result = Exercice01(new Vector3(0.0f, 1.0f, 0.0f), new Vector3(1.0f, 0.0f, 0.0f));

    }

    private int Exercice01(Vector3 vectorOne, Vector3 vectorTwo)
    {
        //On normalise les vectoeur pour les résultats de dot entre 1 et -1
        Vector3 normalizedVectorOne = vectorOne.normalized;
        Vector3 normalizedVectorTwo = vectorTwo.normalized;

        //Dot entre les deux vecteur
        float dot = Vector3.Dot(normalizedVectorOne,normalizedVectorTwo);

        //Sit dot = 1 ils sont alligné
        //Sit dot = -1 ils sont opposé
        if (dot == 1.0f)
            return 1;
        if (dot == -1.0f) 
            return -1;

        //On effectue un cross avec un vecteur sur la 3eme dimension pour obtenir de droite et gauche par rapport au vectorOne
        Vector3 rightVector = Vector3.Cross(normalizedVectorOne,new Vector3( 0.0f, 0.0f, 1.0f));
        Vector3 leftVector = Vector3.Cross(normalizedVectorTwo,new Vector3( 0.0f, 0.0f, -1.0f));

        //Puis on effectue un dot entre ces deux vectoeur et vectorTwo pour savoir le duquel il est le plus proche
        //Si le dot de droitr est plus petit que celui de gauche, alors le VectorTwo se trouve a droite
        if (Vector3.Dot(normalizedVectorTwo,leftVector) <= Vector3.Dot(normalizedVectorTwo,rightVector))
            return 1;

        //Sinon il se trouve a gauche
        return -1;
    }

}
