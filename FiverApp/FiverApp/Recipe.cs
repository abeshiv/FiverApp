//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FiverApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string RecipeType { get; set; }
        public Nullable<int> Servings { get; set; }
        public string Directions { get; set; }
        public Nullable<System.TimeSpan> PrepTime { get; set; }
        public Nullable<System.TimeSpan> CookTime { get; set; }
        public Nullable<int> Ingredient1 { get; set; }
        public Nullable<int> Ingredient2 { get; set; }
        public Nullable<int> Ingredient3 { get; set; }
        public Nullable<int> Ingredient4 { get; set; }
        public Nullable<int> Ingredient5 { get; set; }
        public Nullable<int> Ingredient6 { get; set; }
        public Nullable<int> Ingredient7 { get; set; }
        public Nullable<int> Ingredient8 { get; set; }
        public Nullable<int> Ingredient9 { get; set; }
        public Nullable<int> Ingredient10 { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual Ingredient Ingredient11 { get; set; }
        public virtual Ingredient Ingredient12 { get; set; }
        public virtual Ingredient Ingredient13 { get; set; }
        public virtual Ingredient Ingredient14 { get; set; }
        public virtual Ingredient Ingredient15 { get; set; }
        public virtual Ingredient Ingredient16 { get; set; }
        public virtual Ingredient Ingredient17 { get; set; }
        public virtual Ingredient Ingredient18 { get; set; }
        public virtual Ingredient Ingredient19 { get; set; }
    }
}
