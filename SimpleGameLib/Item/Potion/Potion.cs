using System;

namespace SimpleGameLib.Item.Potion {
    
    /// <summary>
    /// Classe absraite permettant de créer des potions.
    /// Un potion peut être bu et rendra alors une quantité rendu d'un certains paramètre du personnage qui bois la potion
    /// </summary>
    public abstract class Potion : Item {
        
        /// <summary>
        /// Quantité rendu par la potion
        /// </summary>
        protected int rendu;
        
        /// <summary>
        /// Initialisation de la potion
        /// </summary>
        /// <param name="r"> quantité que rendra la potion </param>
        public Potion(int r) {
            this.rendu = r;
        }
        
        /// <summary>
        /// applique l'effet de la potion
        /// </summary>
        /// <param name="player"></param>
        public abstract void applyEffect(Player player);

        /// <summary>
        /// Retourne le type de potion
        /// Soin/Force/Résistance etc...
        /// </summary>
        /// <returns>String</returns>
        protected abstract String getPotionType();
        
        /// <summary>
        /// Affiche les paramètres de la potion sur la sortie console
        /// </summary>
        public void getDescription() {
            Console.WriteLine("Potion de type " + this.getPotionType());
        }

    }
}
