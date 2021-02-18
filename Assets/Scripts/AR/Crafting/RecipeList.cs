using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RecipeList : ScriptableObject
{
    [SerializeField]
    public List<CraftRecipe> recipes;

}
