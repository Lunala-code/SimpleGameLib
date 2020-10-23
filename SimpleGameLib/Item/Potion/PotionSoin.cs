using System;

namespace SimpleGameLib.Item.Potion {

    /// <summary>
    /// Potion de soin
    /// Un potion de soin rends des PV au joueurs
    /// </summary>
    public class PotionSoin : Potion {
        
        /// <summary>
        /// Constructeur de la potion de soin
        /// </summary>
        /// <param name="pr">Point de vie rendu par la potion</param>
        public PotionSoin(int pr) : base(pr) {

        }
        
        /// <summary>
        /// Rends des PV au joueurs
        /// </summary>
        /// <param name="player">Joueur qui bois la potion</param>
        public override void applyEffect(Player player) {
            player.addPv(this.rendu);

        }

        /// <summary>
        /// Donne le type de potion, ici Soin
        /// </summary>
        /// <returns>String</returns>
        protected override String getPotionType() {
            return "Soin";
        }
    }
}
