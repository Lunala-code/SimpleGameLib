

namespace SimpleGameLib.Item.Potion {

    /// <summary>
    /// Potion de force
    /// </summary>
    public class PotionForce : Potion {
        
        /// <summary>
        /// Constructeur de la potion de force
        /// </summary>
        /// <param name="fr">Force que rendra la potion</param>
        public PotionForce(int fr) : base(fr) {

        }
        
        /// <summary>
        /// Rends de la force au joueur
        /// </summary>
        /// <param name="player">Joueur qui boit la potion</param>
        public override void applyEffect(Player player) {
            player.addForce(this.rendu);
        }

        /// <summary>
        /// Donne le type de potion, ici Force
        /// </summary>
        /// <returns>String</returns>
        protected override string getPotionType() {
            return "Force";
        }
    }
}
